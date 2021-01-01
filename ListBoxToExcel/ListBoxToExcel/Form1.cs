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
namespace ListBoxToExcel
{
    public partial class Form1 : Form
    {
        string[] trim;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_Add_Click(object sender, EventArgs e)
        {
         

            listBox1.Items.Add("Ogulcan" + " " + "Gultekin" +" "+ "22");
            listBox1.Items.Add("Can" + " " + "Tekin" +" "+ "22");
            listBox1.Items.Add("Mehmet" + " " + "Tekin" + " " + "22");

        }

        private void excel_Add_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;

            ExcelApp.Worksheets[1].Activate();

            ExcelApp.Cells[1, 1].value = "Name";
            ExcelApp.Cells[1, 2].value = "Surname";
            ExcelApp.Cells[1, 3].value = "Age";
          
            int excel = 2;
            for (int p = 0; p < listBox1.Items.Count; p++)
            {
                if (trim != null)
                {
                    Array.Clear(trim, 0, trim.Length);
                }

                trim = listBox1.Items[p].ToString().Split(' ');


                for (int k = 1; k < trim.Count() + 1; k++)
                {
                    ExcelApp.Cells[excel, k].value = trim[k - 1];

                }
                excel++;

            }
        }
    }
}
