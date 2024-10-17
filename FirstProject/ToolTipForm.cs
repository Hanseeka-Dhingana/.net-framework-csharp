using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class ToolTipForm : Form
    {
        public ToolTipForm()
        {
            InitializeComponent();
        }

        private void ToolTipForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Cyan;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
