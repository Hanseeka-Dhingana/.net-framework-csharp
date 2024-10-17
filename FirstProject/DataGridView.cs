using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            BackColor = Color.Lavender;
            dataGridView1.BackgroundColor = Color.White;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            //Student Record
            DataTable dt1 = new DataTable();    //occupy memory buffer and create logical table  
            dt1.Columns.Add("RNo");
            dt1.Columns.Add("Name");
            dt1.Columns.Add("CMS");
            dt1.Columns.Add("Dept");

            dt1.Rows.Add(101, "Hanseeka", 023 - 22 - 0324, "CS");
            dt1.Rows.Add(102, "Shagufta", 023 - 22 - 0836, "CS");
            dt1.Rows.Add(103, "Prena", 023 - 22 - 9367, "CS");
            dt1.Rows.Add(104, "Marvi", 023 - 22 - 8362, "CS");
               
            //Teacher Record
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Rno");
            dt2.Columns.Add("Tname");
            dt2.Columns.Add("Dept");
            dt2.Columns.Add("sal");

            dt2.Rows.Add(201, "Faiz Lakhani","Computer Science",100000);
            dt2.Rows.Add(202,"Noor Nabi Dahar", "Computer Science",150000);
            dt2.Rows.Add(203, "Ali Raza", "Marketing", 150000);

            DataTable dt3 = new DataTable();
            dt3.Columns.Add("Class");
            dt3.Columns.Add("Lab");
            dt3.Columns.Add("department");

            dt3.Rows.Add("class 1", "lab 1", "Computer Science");
            dt3.Rows.Add("class 2", "Lab 2", "BBA");
            dt3.Rows.Add("class 3", " ", " ");
            dt3.Rows.Add("class 4", " ", " ");
            dt3.Rows.Add("class 5", " ", " ");


            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);
            ds.Tables.Add(dt3);

           
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            
            else if(comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = ds.Tables[1];
            }

            else if(comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = ds.Tables[2];
            }

            else
            {
                label1.Text = "Select from comboBox";
            }

           // dataGridView1.DataSource = dt1;        we also show the record individually using direct the object of datatable.
           // dataGridView1.DataSource = dt2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
