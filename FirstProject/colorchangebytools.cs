using System;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class colorchangebytools : Form
    {
        public colorchangebytools()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void colorchangebytools_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            label1.Text = "This is the color change \n This is font change Program";

        }

        private void colorChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void fontChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change the color without adding the color DialogBox from toolbar 
            // make the object of color Dialog Box
            ColorDialog obj = new ColorDialog();
            obj.ShowDialog();
            BackColor = obj.Color;
            listBox1.Items.Add(label1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
