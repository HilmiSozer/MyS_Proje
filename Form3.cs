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
           SqlCommand sil   = new SqlCommand("DELETE FROM urunler where urun_kodu = '" + dataGridView1.CurrentCell.Value.ToString() + "'" ,baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            listele();
         }

        int adet, fiyat;




        public void listele() {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from urunler ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
       


        private void button4_Click(object sender, EventArgs e)
        {
            adet = Convert.ToInt32(textBox5.Text);
            fiyat = Convert.ToInt32(textBox5.Text);
            baglanti.Open();
            /* SqlCommand guncelle = new SqlCommand("Update urunler set urun_kodu='"+textBox2.Text+ "',urun_ismi='"+textBox3.Text+ "',urun_rengi='"+textBox4.Text+ "',urun_adet='"+textBox5.Text+ "',urun_fiyat='"+textBox6.Text+ "',urun_beden='" +textBox7.Text+ "' , urun_id = ' " + textBox8.Text + "' "+
                 " where urun_kodu='"+ dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'and urun_ismi='"+ dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' and urun_rengi='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'and urun_adet='" + dataGridView1.CurrentRow.Cells[3].Value + "' and " +
                 "urun_fiyat='"+ dataGridView1.CurrentRow.Cells[4].Value + "' and urun_beden='" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'and urun_id='" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "' ", baglanti);
            SqlCommand guncelle = new SqlCommand("Update urunler set urun_kodu='" + textBox2.Text + "',urun_ismi='" + textBox3.Text + "',urun_rengi='" + textBox4.Text + "',urun_adet='" +Convert.ToInt32(textBox5.Text)  + "',urun_fiyat='" + Convert.ToInt32(textBox6.Text) + "',urun_beden='" + textBox7.Text + "' , urun_id = ' " + textBox8.Text + "' where urun_id='"+dataGridView1.CurrentRow.Cells[6].Value.ToString()+"'",baglanti);*/
           
            SqlCommand guncelle = new SqlCommand("Update urunler set urun_kodu = '" + textBox2.Text + "' , urun_ismi = '" + textBox3.Text + "' , urun_rengi = '" + textBox4.Text + "', urun_adet = '" + adet + "' , urun_fiyat = '" + fiyat + "' , urun_beden = '" + textBox7.Text + "' , urun_id = ' " + textBox8.Text + "' where urun_id = '" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "'", baglanti);
            guncelle.ExecuteNonQuery();
            
            baglanti.Close();
            listele();
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
