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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommandBuilder cbuilder;
        DataSet ds;
        SqlCommand komut;
        DataTable tablo;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

            this.MaximumSize = new System.Drawing.Size(600, 490);
            this.MinimumSize = new System.Drawing.Size(600, 490);

            da = new SqlDataAdapter("Select * From SatisRaporu ORDER BY ürünAdet DESC", con);
            ds = new DataSet();
            con.Open();

            da.Fill(ds, "SatisRaporu");
            filterdate.DataSource = ds.Tables["SatisRaporu"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * From SatisRaporu ORDER BY ürünAdet DESC", con);
            ds = new DataSet();
            con.Open();

            da.Fill(ds, "SatisRaporu");
            filterdate.DataSource = ds.Tables["SatisRaporu"];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * From SatisRaporu ORDER BY ürünAdet ASC", con);
            ds = new DataSet();
            con.Open();

            da.Fill(ds, "SatisRaporu");
            filterdate.DataSource = ds.Tables["SatisRaporu"];
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var tarih= dateTimePicker1.Value;

            DateTime iDate = dateTimePicker1.Value;
            var deger = dateTimePicker1.Value.ToString("dd.MM.yyyy");

            da = new SqlDataAdapter("Select * From SatisRaporu WHERE tarih='" + deger.ToString() +"'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "SatisRaporu");
            filterdate.DataSource = ds.Tables["SatisRaporu"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult durum = MessageBox.Show("Satış tablosunu silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                //Kullanıcıya silme onayı penceresi açıp, verdiği cevabı durum değişkenine aktardık.
                if (DialogResult.Yes == durum) // Eğer kullanıcı Evet seçeneğini seçmişse, veritabanından kaydı silecek kodlar çalışır.
                {
                    con.Open();
                    string sql = "DELETE FROM SatisRaporu ";
                    komut = new SqlCommand(sql, con);
                    komut.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Kayıt Silindi...");

                    da = new SqlDataAdapter("Select * From SatisRaporu", con);
                    ds = new DataSet();
                    da.Fill(ds, "SatisRaporu");
                    filterdate.DataSource = ds.Tables["SatisRaporu"];

                    //Silme işlemini gerçekleştirdikten sonra kullanıcıya mesaj verdik.
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Kayıt Silinmede hata oluştu... " + ex);
            }
        }
    }
}
