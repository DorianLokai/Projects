using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Automate_Excel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAutomateExcel_Click(object sender, EventArgs e)
        {
            Excel.Application objExcel = new Excel.Application();
            objExcel.Visible = true;

            // Starts a new workbook and a worksheet.
            Excel.Workbook objBook = objExcel.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet objSheet = (Excel.Worksheet)objBook.Worksheets.get_Item(1);

            Excel.Range objRange;//uses a range object to select

            // populates the selected ranged cells A1 - D1 with the values 75, 125, 255, 295.
            objRange = objSheet.get_Range("A1", System.Reflection.Missing.Value);
            objRange.Value2 = 75;

            objRange = objSheet.get_Range("B1", System.Reflection.Missing.Value);
            objRange.Value2 = 125;

            objRange = objSheet.get_Range("C1", System.Reflection.Missing.Value);
            objRange.Value2 = 255;

            objRange = objSheet.get_Range("D1", System.Reflection.Missing.Value);
            objRange.Value2 = 295;

            objRange = objSheet.get_Range("E1", System.Reflection.Missing.Value);
            objRange.set_Value(System.Reflection.Missing.Value, "=SUM(RC[-4]:RC[-1])");// sums the Colum From A1 - D1 cell in colum E1

            objRange = objSheet.get_Range("A1", "E1");
            objRange.Font.Bold = true;//takes from row A1 - E1 and makes it bold.

            objExcel = null;
        }
    }
}
