using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //For ADO.Net database use.

namespace Database_Example
{
    public partial class MainForm : Form
    {        
        OleDbConnection m_cnADONetConnection = new OleDbConnection();// Modular var to hold connection.
        OleDbDataAdapter m_daDataAdapter; // Modular var for DataAdapter: .        
        OleDbCommandBuilder m_cbCommandBuilder;// Modular var for Command Builder so that you dont have to specify the insert, update and delete statement,
        // You also need to attache the Command Builder to the Data Adapter so that it registers the actions behind the scene.
        DataTable m_dtContacts = new DataTable();
        int m_rowPosition = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\temp\contacts.mdb";
            m_cnADONetConnection.Open();
            
            m_daDataAdapter = new OleDbDataAdapter("Select * From Contacts", m_cnADONetConnection); // Select *(ALL) From Contacts(Database). 
     
            OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter); // Initializing the Command Builder into the Data Adapter.

            m_daDataAdapter.Fill(m_dtContacts);

            this.ShowCurrentRecord();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing the for using the event to ensure all data is released and cleared.
            m_cnADONetConnection.Close();
            m_cnADONetConnection.Dispose();
        }
        private void ShowCurrentRecord()
        {
            if (m_dtContacts.Rows.Count == 0)
            {
                txtContactName.Text = "";
                txtState.Text = "";
                return;
            }
            txtContactName.Text =
               m_dtContacts.Rows[m_rowPosition]["ContactName"].ToString();
            txtState.Text = m_dtContacts.Rows[m_rowPosition]["State"].ToString();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            // Move to the first row and show the data.
            m_rowPosition = 0;
            this.ShowCurrentRecord();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            // If not at the first row, go back one row and show the record.
            if (m_rowPosition != 0)
            {
                m_rowPosition--;
                this.ShowCurrentRecord();
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            // If not on the last row, advance one row and show the record.
            if (m_rowPosition < m_dtContacts.Rows.Count-1)
            {
                m_rowPosition++;
                this.ShowCurrentRecord();
            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            // If there are any rows in the data table, move to the last and show the record.
            if (m_dtContacts.Rows.Count != 0)
            {
                m_rowPosition = m_dtContacts.Rows.Count - 1;
                this.ShowCurrentRecord();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // If there is existing dat, update it.
            if ( m_dtContacts.Rows.Count != 0)
            {
                m_dtContacts.Rows[m_rowPosition]["ContactName"] = txtContactName.Text;
                m_dtContacts.Rows[m_rowPosition]["State"] = txtState.Text;
                m_daDataAdapter.Update(m_dtContacts);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            DataRow drNewRow = m_dtContacts.NewRow();
            drNewRow["ContactName"] = txtNewContactName.Text;
            drNewRow["State"] = txtNewState.Text;
            m_dtContacts.Rows.Add(drNewRow);
            m_daDataAdapter.Update(m_dtContacts);
            m_rowPosition = m_dtContacts.Rows.Count - 1;
            this.ShowCurrentRecord();
            txtNewContactName.Clear(); // clears the text out of the add new name.
            txtNewState.Clear(); // clears the text out of the add new state.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // If there is Data delete the current row.
            if (m_dtContacts.Rows.Count != 0)
            {
                m_dtContacts.Rows[m_rowPosition].Delete();
                m_daDataAdapter.Update(m_dtContacts);
                m_rowPosition = 0;
                this.ShowCurrentRecord();
            }
        }
    }
}
