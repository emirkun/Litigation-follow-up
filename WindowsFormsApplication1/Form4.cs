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
    public partial class Form4 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Data.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter listele;
        DataSet dt = new DataSet();
        public Form4()
        {
            InitializeComponent();
        }

        MailMessage mail = new MailMessage();
        void MailGonder()
        {
            /*/string k_ad = textBox1.Text;
             string sifre = textBox2.Text;
             string mail = textBox5.Text;
             mail.From = new MailAddress("thewallmall0@gmail.com");
             mail.To.Add(mailadresi);
             mail.IsBodyHtml = true;
             mail.Subject = "Siparişiniz Alındı!";
             //  mail.Attachments.Add(new Attachment(DosyaYolu));
             mail.Body = "<b>Adres:</b><br />" + adres + "<br /><b>Ek Not:</b><br />" + eknot + "<br /><b>Alınan Ücret:</b><br />" + label12.Text + "<br /><b>Talimatlarınız üzerine siparişiniz alınmıştır!</b><br /><br /><br /><b>Toplam Tahsis Edilen Ücret:</b><br /> " + label6.Text;
             SmtpClient sc = new SmtpClient();
             sc.Credentials = new System.Net.NetworkCredential("thewallmall0@gmail.com", "");
             sc.Host = "smtp.gmail.com";
             sc.EnableSsl = true;
             sc.Port = 587;
             sc.Send(mail);
             MessageBox.Show("Siparişiniz alındı lütfen mail adresinizi kontrol edin! (Spam klasörünü kontrol edin.)", "Sipariş Alındı!", MessageBoxButtons.OK, MessageBoxIconn.Information);/*/
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verilerilistele();
            bunifuCustomTextbox1.DataBindings.Add("Text",dt,"Dosya.Mahkeme");
            maskedTextBox2.DataBindings.Add("Text", dt, "Dosya.Esas_no");
            maskedTextBox1.DataBindings.Add("Text", dt, "Dosya.buro");
            bunifuCustomTextbox4.DataBindings.Add("Text", dt, "Dosya.davanev");
            bunifuCustomTextbox5.DataBindings.Add("Text", dt, "Dosya.d_aciklama");
            maskedTextBox4.DataBindings.Add("Text", dt, "Dosya.davatarih");
            maskedTextBox3.DataBindings.Add("Text", dt, "Dosya.y_tarih");
            bunifuCustomTextbox8.DataBindings.Add("Text", dt, "Dosya.davali");
            bunifuCustomTextbox9.DataBindings.Add("Text", dt, "Dosya.davaci");
            maskedTextBox5.DataBindings.Add("Text", dt, "Dosya.dosyano");
            //
            pictureBox1.Parent = bunifuGradientPanel1;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Parent = bunifuGradientPanel1;
            pictureBox2.BackColor = Color.Transparent;

            b1.Parent = bunifuGradientPanel1;
            b1.BackColor = Color.Transparent;
            b2.Parent = bunifuGradientPanel1;
            b2.BackColor = Color.Transparent;
            b3.Parent = bunifuGradientPanel1;
            b3.BackColor = Color.Transparent;
            b4.Parent = bunifuGradientPanel1;
            b4.BackColor = Color.Transparent;
            btn8.Parent = bunifuGradientPanel1;
            btn8.BackColor = Color.Transparent;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void verilerilistele()
        {
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM Dosya",conn);
            adt.Fill(dt, "Dosya");
            dataGridView1.DataMember = "Dosya";
            dataGridView1.DataSource = dt;
            adt.Dispose();
        }
        public int VarMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select COUNT(dosyano) from Dosya WHERE dosyano='" + aranan + "'";
            cmd = new OleDbCommand(sorgu, conn);
            conn.Open();

            sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return sonuc;

        }
        private void b4_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Dosya (Mahkeme,Esas_no,buro,davanev,d_aciklama,davatarih,y_tarih,davali,davaci,dosyano) values ('" + bunifuCustomTextbox1.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox1.Text + "','" + bunifuCustomTextbox4.Text + "','" + bunifuCustomTextbox5.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox3.Text + "','" + bunifuCustomTextbox8.Text + "','" + bunifuCustomTextbox9.Text + "','" + maskedTextBox5.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dosyanız başarılı bir şekilde oluşturuldu. Mail adresinizi kontrol ediniz.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }
        private void refresh()
        {
            Form4 frm = new Form4();
            this.Visible = false;
            frm.Show();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            conn.Open();
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Silme işlemini onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                OleDbCommand sil = new OleDbCommand("DELETE * FROM Dosya WHERE dosyano=" + "'" + maskedTextBox5.Text + "'", conn);
                sil.ExecuteNonQuery();
                MessageBox.Show("Seçtiğiniz sütuna ait bilgiler silinmiştir", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                sil.Dispose();
                refresh();
            }
            conn.Close();
        }

        private void List()
        {
            listele = new OleDbDataAdapter("Select * From Dosya", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            listele.Fill(dt);
            dataGridView1.DataSource = dt;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Dosya SET Mahkeme='" + bunifuCustomTextbox1.Text + "',Esas_no='" + maskedTextBox2.Text + "',buro='" + maskedTextBox1.Text + "',davanev='" + bunifuCustomTextbox4.Text + "',d_aciklama='" + bunifuCustomTextbox5.Text + "',davatarih= '" + maskedTextBox4.Text + "',y_tarih='" + maskedTextBox3.Text + "',davali='" + bunifuCustomTextbox8.Text + "',davaci='" + bunifuCustomTextbox9.Text + "'WHERE dosyano='" + maskedTextBox5.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz güncellenmiştir!", "Başarılı!");
            refresh();
            cmd.Dispose();
            conn.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand varmi = new OleDbCommand("SELECT * FROM Dosya",conn);
            OleDbDataReader dr = varmi.ExecuteReader();
            if (dr.Read())
            {
                refresh();
            }
            else
            {
                MessageBox.Show("Kayıtlı dosya yok");
            }
            conn.Close();
        }
    }
}
