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
    public partial class Form1 : Form
    { 

        public Form1()
        { InitializeComponent();
             textBox3.Text = "0";

            if (textBox3.Text == "0")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button6.Visible = false;
                groupBox1.Visible = true;
            }
            else if (textBox3.Text == "1")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button6.Visible = true;
                groupBox1.Hide();
            }

        }

        SqlDataReader gecis;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
         
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 olustur= new Form2(); //ürün oluşturma sayfası
            olustur.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3olustur= new Form3();    //ürün düzenleme sayfası
            form3olustur.ShowDialog();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from admins where id ='" + textBox2.Text + "' and password ='" + textBox4.Text + "' ", baglanti);
            gecis = komut.ExecuteReader();
            if (gecis.Read())
            {
               
                textBox3.Text = "1";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button6.Visible = true;
                groupBox1.Hide();
                baglanti.Close();
                this.InitializeComponent();
                MessageBox.Show("Tebrikler Basarı ile giriş yaptınız.");
 }
            else
            {
               textBox3.Text = "0";
               baglanti.Close();
               MessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text= "0";
            button1.Visible = false; 
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            groupBox1.Visible = true;
            return Form1;
            
        }
    }
    }


