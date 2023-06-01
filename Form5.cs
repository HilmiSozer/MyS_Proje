using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyS_Proje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        int satir = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand ekleme = new SqlCommand("select urun_kodu, urun_ismi, urun_beden, urun_fiyat  from urunler where urun_id like '" + textBox1.Text + "'", baglanti);
            
            SqlDataReader ekle =ekleme.ExecuteReader();
            while (ekle.Read())
            {
                dataGridView1.Rows.Add(ekle);
                dataGridView1.Rows[satir].Cells[0].Value=(ekle["urun_kodu"].ToString());
                dataGridView1.Rows[satir].Cells[1].Value = (ekle["urun_ismi"].ToString());
                dataGridView1.Rows[satir].Cells[2].Value = (ekle["urun_beden"].ToString());
                dataGridView1.Rows[satir].Cells[3].Value = (ekle["urun_fiyat"].ToString());
                satir++;




            }
            ekle.Close();
            baglanti.Close();
        }
    }
}
