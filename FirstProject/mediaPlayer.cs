using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class mediaPlayer : Form
    {
        public mediaPlayer()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void mediaPlayer_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Pink;
        }
    }
}
