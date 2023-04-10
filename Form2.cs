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

namespace MyS_Proje
{
    public partial class Form2 : Form

    {
        public Form2() { InitializeComponent(); }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            Random sayi = new Random();


            int rnd = sayi.Next(1000);
            label1.Text = rnd.ToString();
            textBox6.Text = "STANDART";
            textBox6.Text = "STANDART";
            textBox6.Text = "STANDART";
            textBox6.Text = "STANDART";
            textBox6.Text = "STANDART";
            textBox6.Enabled = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
           
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Visible = false;
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.SelectedIndex = 0;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox5.Text == "")
            {
                MessageBox.Show("Değerler boş olamaz.", "Uyarı");
            }
            else
            {
                if(comboBox2.SelectedIndex==0)
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + textBox3.Text + "','" + textBox5.Text + "')", baglanti);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox6.Enabled = true;
                textBox6.Text = "STANDART";
                textBox6.Enabled = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
               
                comboBox1.Visible = false;

            }
            else if (checkBox1.Checked == true)
            {
                comboBox1.Visible = true;
                textBox6.Enabled = true;
                textBox6.Clear();

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                if(comboBox1.SelectedIndex == 0)
            {
                textBox7.Visible = false;
                textBox8.Visible = true;
                textBox9.Visible = false;
                textBox10.Visible = false;
                

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox7.Visible = false;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = false;
               

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = false;
               

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
               

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
            }
            else if (comboBox2.SelectedIndex == 1) { 
            
                
                textBox10.Visible = false;
                textBox15.Visible = true ;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
            }

        
            else if (comboBox2.SelectedIndex == 2)
            {
                
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = false;
                textBox18.Visible = false;
            }

            else if (comboBox2.SelectedIndex == 3)
            {
                
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = false;
                textBox18.Visible = true;
               
            }
            else if (comboBox2.SelectedIndex == 4)
            {
               
                textBox17.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox18.Visible = true;

            }
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
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();  textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
            textBox10.Clear();  textBox16.Clear(); textBox17.Clear(); textBox18.Clear();
            listele();
        }
    }
}
