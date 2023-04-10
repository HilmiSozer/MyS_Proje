using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyS_Proje
{
    public partial class login : Form
    {
        
            
        public login()
        {
            InitializeComponent();
            
            
        }

        SqlDataReader gecis;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from admins where id ='" + textBox1.Text + "' and password ='" + textBox2.Text + "' ", baglanti);
            gecis = komut.ExecuteReader();
            if (gecis.Read())
            {
                
                 textBox3.Text = "1";
                form1.Show();
                MessageBox.Show("Tebrikler Basarı ile giriş yaptınız.");
                
                baglanti.Close();
                
                Close();
               
                
                
            }
            else {
                MessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz.");
                textBox3.Text = "0";
                baglanti.Close();
            }
            if (textBox3.Text=="1")
            {
                
                
            }
        }
        
}
}
