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
using System.Reflection.Emit;

namespace MyS_Proje
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)

        {
            listele();
        }
            
        private void button1_Click(object sender, EventArgs e)


        { baglanti.Open();
           SqlCommand sil   = new SqlCommand("DELETE FROM urunler where urun_id = '"+textBox8.Text+"'" ,baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            textBox1_TextChanged(sender, e);
        }

        int adet;
           decimal fiyat;




        public void listele() {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from urunler ",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
       


        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox5.Text!="")
            adet = Convert.ToInt32(textBox5.Text);

            if (textBox6.Text != "")
                fiyat = Convert.ToDecimal(textBox6.Text);

            baglanti.Open();
           
            SqlCommand guncelle = new SqlCommand("Update urunler set urun_kodu = '"+ textBox2.Text +"' , urun_ismi = '" + textBox3.Text + "' , urun_rengi = '" + textBox4.Text + "', urun_adet = '" + adet + "' ," +
                " urun_fiyat = '" +fiyat+ "' , urun_beden = '" + textBox7.Text + "' , urun_id = '"+textBox8.Text+"' where urun_id = '"+dataGridView1.CurrentRow.Cells[6].Value.ToString()+"'", baglanti);
            guncelle.ExecuteNonQuery();
            
            baglanti.Close();
            textBox1_TextChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from urunler where urun_kodu like '%"+textBox1.Text+"%' or urun_ismi like '%"+textBox1.Text+"%' ", baglanti);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
