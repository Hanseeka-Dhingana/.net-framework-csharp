using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class fileDialogBox : Form
    {
        public fileDialogBox()
        {
            InitializeComponent();
        }

        private void fileDialogBox_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BackColor = Color.SkyBlue;

            pictureBox1.BackColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //first we create the object if we can't pick the openFileDialog from the toolbar 
            //otherwise we direct use this 

            openFileDialog1.Filter = "chooseImage(*.jpg;*.png;*.jfif;)|*.jpg;*.png;*.jfif;";
            //filter the file which is have only jpg,png,and jfif in the extension.

            openFileDialog1.ShowDialog();

            //Set the progress bar from 0 to 201
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 201;
            progressBar1.Value = 1;

            for(int  i = 2; i<= 200; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(10);   //Thread sleep object used to stop the function 10 milisecond
                 
            }
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
