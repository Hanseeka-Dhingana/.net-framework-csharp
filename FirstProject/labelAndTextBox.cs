using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class labelAndTextBox : Form
    {
        public labelAndTextBox()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Name";
            label2.Text = "CMS-ID";

            WindowState = FormWindowState.Maximized;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
            textBox2.ForeColor = colorDialog1.Color;
            
        }
    }
}
