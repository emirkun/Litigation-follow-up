using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Data.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter listele;
        DataSet dt = new DataSet();
        public Form5()
        {
            InitializeComponent();
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        public void verilerilistele()
        {
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM Durusma", conn);
            adt.Fill(dt, "Durusma");
            dataGridView1.DataMember = "Durusma";
            dataGridView1.DataSource = dt;
            adt.Dispose();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            verilerilistele();
            dateTimePicker2.DataBindings.Add("Text", dt, "Durusma.d_tarih");
            maskedTextBox2.DataBindings.Add("Text", dt, "Durusma.d_saat");
            dateTimePicker1.DataBindings.Add("Text", dt, "Durusma.kesif_tarih");
            textBox1.DataBindings.Add("Text", dt, "Durusma.mehilsuresi");
            dateTimePicker3.DataBindings.Add("Text", dt, "Durusma.muracat_tarih");
            textBox2.DataBindings.Add("Text", dt, "Durusma.d_no");

            pictureBox1.Parent = bunifuGradientPanel1;
            pictureBox1.BackColor = Color.Transparent;
            

            b1.Parent = bunifuGradientPanel1;
            b1.BackColor = Color.Transparent;
            b2.Parent = bunifuGradientPanel1;
            b2.BackColor = Color.Transparent;
            b3.Parent = bunifuGradientPanel1;
            b3.BackColor = Color.Transparent;
            b4.Parent = bunifuGradientPanel1;
            b4.BackColor = Color.Transparent;
            b8.Parent = bunifuGradientPanel1;
            b8.BackColor = Color.Transparent;
        }

        public int VarMi(string aranan)
        {
            int sonuc;
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
            string sorgu = "Select COUNT(d_no) from Durusma WHERE d_no='" + aranan + "'";
            cmd = new OleDbCommand(sorgu, conn);
            conn.Open();

            sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return sonuc;

        }

        private void List()
        {
            
        }

        private void refresh()
        {
            Form5 frm = new Form5();
            this.Visible = false;
            frm.Show();
        }
        private void b4_Click(object sender, EventArgs e)
        {
            string durusmatarih = dateTimePicker2.Text;
            string kesiftarih = dateTimePicker1.Text;
            string muracattarih = dateTimePicker3.Text;
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Durusma (d_tarih,d_saat,kesif_tarih,mehilsuresi,muracat_tarih,d_no) values ('" + durusmatarih + "','" + maskedTextBox2.Text + "','" + kesiftarih + "','" + textBox1.Text + "','" + muracattarih + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Duruşmanız başarılı bir şekilde oluşturuldu. Mail adresinizi kontrol ediniz.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }

       
        private void b3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            conn.Open();
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Silme işlemini onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                OleDbCommand sil = new OleDbCommand("DELETE * FROM Durusma WHERE d_no=" + "'" + textBox2.Text + "'", conn);
                sil.ExecuteNonQuery();
                MessageBox.Show("Seçtiğiniz sütuna ait bilgiler silinmiştir", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                sil.Dispose();
                refresh();
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void b8_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand varmi = new OleDbCommand("SELECT * FROM Durusma", conn);
            OleDbDataReader dr = varmi.ExecuteReader();
            if (dr.Read())
            {
                refresh();
            }
            else
            {
                MessageBox.Show("Kayıtlı Durusma yok");
            }
            conn.Close();
        }
    }
}
