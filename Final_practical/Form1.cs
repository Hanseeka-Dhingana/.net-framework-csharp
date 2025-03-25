using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Press_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            int num = Int32.Parse(tb1.Text);

            dt.Columns.Add("num");
            dt.Columns.Add("Multiply");
            dt.Columns.Add("num2");
            dt.Columns.Add("equal");
            dt.Columns.Add("value");


            for(int i= 1; i<=10; i++)
            {
                int value = num * i;
                dt.Rows.Add(num, " * ", i, " = ", value);
            }

            dg1.DataSource = dt;
            
        }
    }
}
