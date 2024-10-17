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
    public partial class MenuStripForm : Form
    {
        public MenuStripForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Lavender;
        }

        private void dT1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dT1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog Fd = new FontDialog();
            if(Fd.ShowDialog() == DialogResult.OK)
            {
                label1.Font = Fd.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog Cd = new ColorDialog();
            Cd.ShowDialog();
            label1.ForeColor = Cd.Color;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
            label1.ForeColor = Color.White;
            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void colorPickerByTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            labelAndTextBox obj = new labelAndTextBox();
            obj.Show();
            
            
        }

        private void colorPickerByToolBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            colorchangebytools obj = new colorchangebytools();
            obj.Show();
        }

        private void fileDialogBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            fileDialogBox obj = new fileDialogBox();
            obj.Show();
        }

        private void backgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BackgroundWorker obj = new BackgroundWorker();
            obj.Show();
        }

        private void toolTipFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ToolTipForm obj = new ToolTipForm();
            obj.Show();
        }

        private void mediaPlayerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            mediaPlayer obj = new mediaPlayer();
            obj.Show();
        }
        

        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DataGridView obj = new DataGridView();
            obj.Show();
        }

        private void backgroundColorChangeByButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BacgroundColorChange obj = new BacgroundColorChange();
            obj.Show();
        }

        private void backgroundColorChangeByTimeIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Hide();
            BackgroundChanegByTimeInterval obj = new BackgroundChanegByTimeInterval();
            obj.Show();

        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            PictureBox obj = new PictureBox();
            obj.Show();
        }

        private void textFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TextField obj = new TextField();
            obj.Show();
        }
    }
}
 