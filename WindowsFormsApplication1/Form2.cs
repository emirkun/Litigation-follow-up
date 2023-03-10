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
    public partial class Form2 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        public int VarMi(string aranan)
        {
            int sonuc;
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
            string sorgu = "Select COUNT(k_mail) from giris WHERE k_mail='" + aranan + "'";
            cmd = new OleDbCommand(sorgu, con);
            con.Open();

            sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return sonuc;

        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string ad = txt1.Text;
            string sifre = btn3.Text;
            string mail = btn2.Text;
            if (VarMi(btn2.Text) != 0)
            {
                MessageBox.Show("Bu mail adresi ile daha önce kayıt yapılmıştır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into giris (k_ad,k_soyad,k_mail) values ('" + txt1.Text + "','" + btn3.Text + "','" + btn2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnKyt2.Parent = bunifuGradientPanel1;
            btnKyt2.BackColor = Color.Transparent;

            

            btn2.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            btn3.Visible = false;
            btnKyt2.Visible = false;
        }

        private void txt1_OnValueChanged(object sender, EventArgs e)
        {
            if (txt1 != null)
            {
                btn2.Visible = true;
                lbl2.Visible = true;
            }
        }

        private void btn2_OnValueChanged(object sender, EventArgs e)
        {
            if (btn2 != null)
            {
                btn3.Visible = true;
                lbl3.Visible = true;
            }
        }

        private void btn3_OnValueChanged(object sender, EventArgs e)
        {
            if (btn3 != null)
            {


                btnKyt2.Visible = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
