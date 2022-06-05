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
    public partial class Product_Update : Form
    {
        public Product_Update()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommandBuilder cbuilder;
        DataSet ds;
        SqlCommand komut;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");


        private void Product_Update_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(610, 490);
            this.MinimumSize = new System.Drawing.Size(610, 490);

            con.Open();
            da = new SqlDataAdapter("Select * From Urün", con);
            ds = new DataSet();
            da.Fill(ds, "Urün");
            prdcdata.DataSource = ds.Tables["Urün"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("UPDATE Urün SET  ürünAdı='" + prdctname.Text + "',ürünAdet='" + prdctcount.Text + "', ürünRenk='" + prdctcolor.Text + "',ürünFiyat='" + prdctprice.Text + "' where id='" + label6.Text + "'", con);
                cmd.ExecuteNonQuery();

                //SqlCommand cmd = new SqlCommand("UPDATE Urün SET  ürü_adı='" + textBox1.Text + "', ürün_renk='" + textBox2.Text + "',ürün_markası='" + textBox3.Text + "',ürün_sayısı='" + textBox4.Text + "',ürün_fiyatı='" + textBox5.Text + "' where id='" + label7.Text + "'", baglanti);
                //cmd.ExecuteNonQuery();


                da = new SqlDataAdapter("Select * From Urün", con);
                ds = new DataSet();
                da.Fill(ds, "Urün");
                prdcdata.DataSource = ds.Tables["Urün"];

                var myForm = new Kırtasiye_otomasyonu();
                myForm.Show();

                myForm.dataGridView1.DataSource = ds.Tables["Urün"];
    
                this.Hide();


                con.Close();
                MessageBox.Show("Ürün başarılı şekilde güncellendi");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ürüm Güncellenemedi ! " + ex);
            }
        }
    }
}
