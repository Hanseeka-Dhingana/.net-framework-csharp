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
    public partial class BackgroundChanegByTimeInterval : Form
    {
        public BackgroundChanegByTimeInterval()
        {
            InitializeComponent();
        }
         
        private void BackgroundChanegByTimeInterval_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int a = rd.Next(0, 225);
            int b = rd.Next(0, 255);
            int c = (a + b / 2);

           BackColor = Color.FromArgb(a, b, c);
        }
    }
}
