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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Zen.Barcode;

namespace MyS_Proje
{
    public partial class Form2 : Form

    {int counter;
        
        public Form2() { InitializeComponent();  
        SqlCommand update = new SqlCommand("update itemscounter set '"+counter+"' ", baglanti);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            
            baglanti.Open();
            
            SqlDataReader read;
            SqlCommand counteradder = new SqlCommand("select *from itemscounter  ", baglanti);
            counteradder.ExecuteNonQuery();
            read = counteradder.ExecuteReader();
            while (read.Read())
                textBox1.Text = read["itemscount"].ToString();

            baglanti.Close();
            counter = Convert.ToUInt16(textBox1.Text)+1;
            
           

        

            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            
            baglanti.Close();
            if (textBox1.Text == "" | textBox2.Text == ""  | textBox5.Text == "")
            {
                MessageBox.Show("Değerler boş olamaz.", "Uyarı");
            }
            else
            {
                
                baglanti.Open();
              
                SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button3.Text + "','" + textBox5.Text + "')", baglanti);
                komut.ExecuteNonQuery();
               
                baglanti.Close();
                listele();


            }
        }
        public void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        
       
        

        private void button2_Click(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from urunler where urun_kodu like '%" + textBox1.Text + "%' and urun_ismi like '%" + textBox2.Text +"%' ", baglanti);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear();   textBox5.Clear(); 
            listele();
        }

        
    }
}
