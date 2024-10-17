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
    public partial class PictureBox : Form
    {
        int next =1;
        string path;

        public PictureBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
            this.Text = "Picture Changed Program";
            pictureBox1.Image = Image.FromFile("C:\\xampp\\htdocs\\Mypro\\images\\1.jfif");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            next++;

            if(next > 10)
            {
                next = 1;
            }

            path = "C:\\xampp\\htdocs\\Mypro\\images\\" + next + ".jfif";
            pictureBox1.Image = Image.FromFile(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            next--;
            if(next == 0)
            {
                next = 10;
            }

            path = "C:\\xampp\\htdocs\\Mypro\\images\\" + next + ".jfif";
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
