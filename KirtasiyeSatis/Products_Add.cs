using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirtasiyeSatis
{
    public partial class Products_Add : Form
    {
        public Products_Add()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        private void Products_Add_Load(object sender, EventArgs e)
        {

            this.MaximumSize = new System.Drawing.Size(896, 455);
            this.MinimumSize = new System.Drawing.Size(896, 455);

            baglanti.Open();

            da = new SqlDataAdapter("Select * From Kategori", baglanti);
            ds = new DataSet();
            da.Fill(ds, "Kategori");
            ctgrdata.DataSource = ds.Tables["Kategori"]; 
            
            
            da = new SqlDataAdapter("Select * From Urün", baglanti);
            ds = new DataSet();
            da.Fill(ds, "Urün");
            prdcdata.DataSource = ds.Tables["Urün"];



            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {

                
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Kategori (kategoriAdı,kategoriNo)   values ('" + ktgrname.Text + "','" + ktgrno.Text + "')",baglanti);
                cmd.ExecuteNonQuery();
             
                da = new SqlDataAdapter("Select * From Kategori", baglanti);
                ds = new DataSet();
                da.Fill(ds, "Kategori");
                ctgrdata.DataSource = ds.Tables["Kategori"];
                baglanti.Close();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kategori Kayıt İşlemi Gerçekleşti.", "Kategori Kayıt edildi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Urün (ürünAdı,ürünAdet,ürünRenk,ürünFiyat)   values ('" + prdctname.Text + "','" + prdctcount.Text + "','" + prdctcolor.Text + "','" + prdctprice.Text + "')", baglanti);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter("Select * From Urün", baglanti);
                ds = new DataSet();
                da.Fill(ds, "Urün");
                prdcdata.DataSource = ds.Tables["Urün"];
                baglanti.Close();

                baglanti.Close();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Ürün Kayıt İşlemi Gerçekleşti.", "Ürün Kayıt edildi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            da = new SqlDataAdapter("Select * From Urün", baglanti);
            ds = new DataSet();
            da.Fill(ds, "Urün");
            prdcdata.DataSource = ds.Tables["Urün"];



            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in ctgrdata.SelectedRows)  //Seçili Satırları Silme
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(id);
                }

                da = new SqlDataAdapter("Select * From Kategori", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Kategori");
                ctgrdata.DataSource = ds.Tables["Kategori"];
                baglanti.Close();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kategori Silme İşlemi Gerçekleşti.", "Kategori silindi !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            }
            catch (Exception)
            {

                throw;
            }
        }

        void KayıtSil(int id)
        {
            string sql = "DELETE FROM Kategori WHERE id=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in prdcdata.SelectedRows)  //Seçili Satırları Silme
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil2(id);
                }

                da = new SqlDataAdapter("Select * From Urün", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Urün");
                prdcdata.DataSource = ds.Tables["Urün"];
                baglanti.Close();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Ürün Silme İşlemi Gerçekleşti.", "Ürün silindi !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            catch (Exception)
            {
                throw;
            }
        }

        void KayıtSil2(int id)
        {

            string sql = "DELETE FROM Urün WHERE id=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

    }
}
