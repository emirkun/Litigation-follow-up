using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        OleDbDataAdapter listele;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Data.accdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = bunifuGradientPanel1;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.Parent = bunifuGradientPanel1;
            pictureBox3.BackColor = Color.Transparent;

            b1.Parent = bunifuGradientPanel1;
            b1.BackColor = Color.Transparent;
            b2.Parent = bunifuGradientPanel1;
            b2.BackColor = Color.Transparent;
            b3.Parent = bunifuGradientPanel1;
            b3.BackColor = Color.Transparent;
            b4.Parent = bunifuGradientPanel1;
            b4.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

        private void List()
        {
            conn.Open();
            listele = new OleDbDataAdapter("Select * From Dosya", conn);
            DataSet  ds = new DataSet();
            DataTable dt = new DataTable();
            listele.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            List();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void List2()
        {
            conn.Open();
            listele = new OleDbDataAdapter("Select * From Dosya", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            listele.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void b4_Click(object sender, EventArgs e)
        {

        }
    }
}
