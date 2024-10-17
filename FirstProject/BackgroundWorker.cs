using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class BackgroundWorker : Form
    {
        public BackgroundWorker()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Lavender;
        }

        //first execute this method 
        private void BGW1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int a =1; a <=100; a++)
            {
                Thread.Sleep(100);
                BGW1.ReportProgress(50);
            }

        }

        //This method execute after each execution of BGWQ_DoWork method until the loop doesn't cmplt
        private void BGW1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value += 1;

            Random obj = new Random();
            int a = obj.Next(0, 255);
            int b = obj.Next(0, 255);
            int c = (a + b) / 2;

             panel.BackColor = Color.FromArgb(a, b, c);
        }
        //when loop complt in dowork method then this method execute and show the message
        private void BGW1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Task Completed");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            BGW1.RunWorkerAsync();  //this execute the background worker

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
           
        }
    }
}
