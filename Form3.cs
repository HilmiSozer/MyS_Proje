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
using System.Security.Cryptography;

namespace MyS_Proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)


        { baglanti.Open();
           SqlCommand sil   = new SqlCommand("DELETE FROM urunler where urun_kodu = '" + dataGridView1.CurrentCell.Value.ToString() + "'" ,baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            listele();
         }  
        

        private void Form3_Load(object sender, EventArgs e)

        {listele();}
            
            
            
        
        public void listele()
        { baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from urunler ", baglanti);
            DataTable dt = new DataTable();           
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
         }  
        



        private void button2_Click(object sender, EventArgs e)
        { baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from urunler where urun_ismi like '%" + textBox1.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource= dt;
            baglanti.Close();
         }  
        



        private void button3_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();

            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayit = new SqlCommand("UPDATE urunler set '" + dataGridView1.CurrentCell.Value + "' where urun_adet= '"+dataGridView1.CurrentCell.Value.ToString() +"'  " , baglanti);
            kayit.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }
    }
}
