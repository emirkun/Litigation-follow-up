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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (txt1 != null)
            {
                btn2.Visible = true;
                lbl2.Visible = true;
            }
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiris.Visible = false;
            btn2.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            btn3.Visible = false;
            bunifuiOSSwitch1.Visible = false;

            btnGiris.Parent = bunifuGradientPanel1;
            btnGiris.BackColor = Color.Transparent;
            btnKyut.Parent = bunifuGradientPanel1;
            btnKyut.BackColor = Color.Transparent;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn2_OnValueChanged(object sender, EventArgs e)
        {
            if (btn2 != null)
            {
                btn3.Visible = true;
                lbl3.Visible = true;
                bunifuiOSSwitch1.Visible = true;
            }
        }

        private void btn3_OnValueChanged(object sender, EventArgs e)
        {
            if (btn3 != null)
            {
                

                btnGiris.Visible = true;
                
            }

           
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || btn2.Text == "" || btn3.Text == "")
            {
                MessageBox.Show("Bütün satırları doldurmanız gerekiyor!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ad = txt1.Text;
                string sifre = btn3.Text;
                string mail = btn2.Text;
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM giris where k_ad='" + txt1.Text + "' AND k_soyad='" + btn3.Text + "' AND k_mail='" + btn2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi doğru girdiğinizden emin olun!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();



                
            }

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                btn3.isPassword = true;
            }

            if (bunifuiOSSwitch1.Value == false)
            {
                btn3.isPassword = false;
            }
        }
    }
}
