using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class TextField : Form
    {
        public TextField()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextField_Load(object sender, EventArgs e)
        {
            this.Text = "Label TextBox RadioButton ComboBox CheckBox";
            BackColor = Color.Lavender;

            comboBox1.Items.Add("Sukkur IBA Univeristy");
            comboBox1.Items.Add("Zabist University");
            comboBox1.Items.Add("Iqra University");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedItem == "Sukkur IBA University")
            {
                Process.Start("https://www.iba-suk.edu.pk/");
            }
            
            if(comboBox1.SelectedItem == "Zabist University")
            {
                Process.Start("https://szabist.edu.pk/");
            }
            if(comboBox1.SelectedItem == "Iqra University")
            {
                Process.Start("https://iqra.edu.pk/");
            }
        
        }
    }
}
