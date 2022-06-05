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
    public partial class Kırtasiye_otomasyonu : Form
    {
        public Kırtasiye_otomasyonu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Products_Add();
            myForm.Show();
        }
 
        SqlDataAdapter da;
        SqlCommandBuilder cbuilder;
        DataSet ds;
        SqlCommand komut;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\KirtasiyeSatis\kirtasiyesatis.mdf; Integrated Security = true;");

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(610, 370);
            this.MinimumSize = new System.Drawing.Size(610, 370);

            da = new SqlDataAdapter("Select * From Urün", con);
            ds = new DataSet();
            con.Open();

            da.Fill(ds, "Urün");
            dataGridView1.DataSource = ds.Tables["Urün"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var myForm = new Customer();
            myForm.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(id);
                }

                da = new SqlDataAdapter("Select * From Urün", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Urün");
                dataGridView1.DataSource = ds.Tables["Urün"];
                con.Close();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Ürün Silme İşlemi Gerçekleşti.", "Ürün silindi !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            }
            catch (Exception)
            {

                throw;
            }
           


        }

        void KayıtSil(int id)
        {
            string sql = "DELETE FROM Urün WHERE id=@id";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@id", id);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var myForm = new Products_Add();
            myForm.Show();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            var myForm = new Sales();
            myForm.Show();
            try
            {

                myForm.prdctname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
                myForm.prdctcount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //[0] sütun numarası
                myForm.prdctcolor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //[0] sütun numarası
                myForm.prdctprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //[0] sütun numarası
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var myForm = new Sales();
            myForm.prdctname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
            myForm.prdctcount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //[0] sütun numarası
            myForm.prdctcolor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //[0] sütun numarası
            myForm.prdctprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //[0] sütun numarası
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            var myForm = new Product_Update();
            myForm.Show();
            try
            {

                myForm.label6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //[0] sütun numarası
                myForm.prdctname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
                myForm.prdctcount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //[0] sütun numarası
                myForm.prdctcolor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //[0] sütun numarası
                myForm.prdctprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //[0] sütun numarası
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Reports();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("Select * From Urün", con);
            ds = new DataSet();
            con.Open();

            da.Fill(ds, "Urün");
            dataGridView1.DataSource = ds.Tables["Urün"];
            con.Close();
        }
    }
    
}
