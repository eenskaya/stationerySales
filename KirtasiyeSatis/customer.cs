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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");

        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;


        private void btnccutomer_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Müsteri (müsteriAdı,müsteriSoyadı,müsteriTc,müsteriTelefon,müsteriAdres)   values ('" + customername.Text + "','" + customersurname.Text + "','" + customertc.Text + "','" + customerphone.Text + "','" + customeradress.Text + "')", baglanti);
                cmd.ExecuteNonQuery();

       
                da = new SqlDataAdapter("Select * From Müsteri", baglanti);
                ds = new DataSet();
                da.Fill(ds, "Müsteri");
                customerdata.DataSource = ds.Tables["Müsteri"];


                baglanti.Close();

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.", "Müşteri Kayıt edildi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }
        }

        private void customer_Load(object sender, EventArgs e)
        {

            this.MaximumSize = new System.Drawing.Size(816, 328);
            this.MinimumSize = new System.Drawing.Size(816, 328);
     
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Müsteri", baglanti);
            ds = new DataSet();
            da.Fill(ds, "Müsteri");
            customerdata.DataSource = ds.Tables["Müsteri"];
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in customerdata.SelectedRows)  //Seçili Satırları Silme
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(id);
                }

                da = new SqlDataAdapter("Select * From Müsteri", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Müsteri");
                customerdata.DataSource = ds.Tables["Müsteri"];
                baglanti.Close();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Müşteri Silme İşlemi Gerçekleşti.", "Müşteri silindi !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            }
            catch (Exception)
            {

                throw;
            }

        }

        void KayıtSil(int id)
        {
            string sql = "DELETE FROM Müsteri WHERE id=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

    }
}
