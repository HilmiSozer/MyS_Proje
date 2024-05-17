using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyS_Proje
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        SqlCommand renk;
        SqlCommand beden;
       
        
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir değer girin.","HATA");
            }
            else
            {
          baglanti.Open();
            renk = new SqlCommand("insert into colors (RENK) values( '"+textBox1.Text+"')", baglanti);
            renk.ExecuteNonQuery();
            baglanti.Close();   
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen bir değer girin.", "HATA");
            }
            else
            {
          baglanti.Open();
            beden = new SqlCommand("alter table colors add ["+textBox2.Text+"] bit ", baglanti);
            beden.ExecuteNonQuery();
            }
           
        }
    }
}
