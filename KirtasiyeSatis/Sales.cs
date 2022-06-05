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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand komut;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");

        private void Sales_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(950, 410);
            this.MinimumSize = new System.Drawing.Size(950, 410);

            da = new SqlDataAdapter("Select * From SatisRaporu", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "SatisRaporu");
            salesdata.DataSource = ds.Tables["SatisRaporu"];



            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Müsteri";
            komut.Connection = con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                customerSelect.Items.Add(dr["müsteriAdı"]);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Kırtasiye_otomasyonu();

            try
            {
                int adet;
                adet = int.Parse(prdctcount.Text);
                SqlCommand sorgu = new SqlCommand("Select * From Urün where ürün", con);
                con.Open();
                DateTime now = DateTime.Today;
                var deger = now.ToString("dd.MM.yyyy");
                SqlCommand cmd = new SqlCommand("INSERT INTO SatisRaporu (ürünAdı,ürünFiyat,müsteriAdı,müsteriTelefon,tarih,ürünToplamfiyat,ürünAdet) VALUES ('" + prdctname.Text + "','" + prdctprice.Text + "','" + customername.Text + "','" + customerphone.Text + "','" + Convert.ToString(deger) + "','" + totalprice.Text + "','" + prdctcount.Text + "')", con);

                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("UPDATE Urün SET ürünAdet=ürünAdet-('" + adet + "') where ürünAdı='" + prdctname.Text + "'", con);
                cmd2.ExecuteNonQuery();



                da = new SqlDataAdapter("Select * From SatisRaporu", con);
                ds = new DataSet();
                da.Fill(ds, "SatisRaporu");
                salesdata.DataSource = ds.Tables["SatisRaporu"];


                da = new SqlDataAdapter("Select * From Urün", con);
                ds = new DataSet();       
                da.Fill(ds, "Urün");
                myForm.dataGridView1.DataSource = ds.Tables["Urün"];
                con.Close();


                MessageBox.Show("Satış işlemi tamamlandı ! ");
                this.Hide();


                con.Open();
                da = new SqlDataAdapter("Select * From Urün", con);
                ds = new DataSet();
                da.Fill(ds, "Urün");
                myForm.dataGridView1.DataSource = ds.Tables["Urün"];
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Satış işlemi tamamlanamadı ! " + ex);
            }

           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(prdctcount.Text);
            int price = Convert.ToInt32(prdctprice.Text);
            int total = 0;
            total = count * price;
            totalprice.Text = total.ToString() + " TL";
        }

        private void customerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = customerSelect.SelectedItem.ToString();
            string dbphone = "";
            string dbcustomername = "";
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Müsteri  where müsteriAdı='" + customer.ToString() + "'", con);
            con.Open();

            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                dbcustomername = dr[1].ToString();
                dbphone = dr[3].ToString();
            }
            customername.Text = dbcustomername;
            customerphone.Text = dbphone;
            con.Close();
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
