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
    public partial class BacgroundColorChange : Form
    {
        public BacgroundColorChange()
        {
            InitializeComponent();
        }

        private void BacgroundColorChange_Load(object sender, EventArgs e)
        {
            BackColor = Color.Lavender;
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            Random r = new Random();
            int a = r.Next(0, 255);
            int b = r.Next(0, 255);
            int c = a + b / 2;

            BackColor = Color.FromArgb(a, b, c);

            if(BackColor == Color.DeepPink || BackColor == Color.MediumPurple)
            {
                label1.ForeColor = Color.White;
            }
        }
    }
}
