using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class Form1 : Form
    {

        int x = 12;
        int y = 12;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
            WindowState = FormWindowState.Maximized;

            pictureBox1.Image = Image.FromFile("C:\\Users\\Hansika\\OneDrive\\Pictures\\star-removebg-preview (1).png");


            timer1.Interval = 1;
            timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {  
            
            
          
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
             if(x != 1200 && y == 12)
            {
                x++;
            }
            
            if (x >= 1200 )
            {
                x = 1200;
                BackColor = Color.Lavender;
                y++;
            }

            if(y >= 600 )
            {
                y = 600;
                BackColor = Color.Red;
                x--;
            }

            if( x == 12 && y!=12)
            {
                BackColor = Color.Blue;
                y--;

                if(y == 12)
                {
                    BackColor = Color.LightGray;
                    x = 600;
                    y = 300;
                    timer1.Stop();
                }
            }

            
            pictureBox1.Location = new Point(x, y);




        }
    }
}
