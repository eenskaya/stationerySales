using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirtasiyeSatis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename="+ Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");
 
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string kullanici_Adi = txtkullanici.Text;
            string kullanici_Parola = txtparola.Text;
            /*Kullanıcı bilgileri login veri tabanında olup olmadığını kontrol ediyorum*/
            string sorgu = "Select * from Login where kullanıcıAdı='" + kullanici_Adi.Trim() + "' AND parola='" + kullanici_Parola.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            /*Girilen bilgiler veritabanında varsa form2 açtırıyorum*/
            if (dta.Rows.Count == 1)  
            {
                var myForm = new Kırtasiye_otomasyonu();
                myForm.Show();
                this.Hide();
            }
            else
            {
                /*Girilen bilgiler yanlış ise kullanıcıya mesaj verip tekrar denemesini veya kapatmasını sağlıyorum*/
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kullanıcı bilgileri doğru şekilde girilmedi !", "Oturum Açılamadı !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(513, 256);
            this.MinimumSize = new System.Drawing.Size(513, 256);


        }
    }
}

