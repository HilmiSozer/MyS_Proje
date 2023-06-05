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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MyS_Proje
{
    public partial class Form2 : Form

    {
        
        public Form2() { InitializeComponent();  
        SqlCommand update = new SqlCommand("update itemscounter set '"+counter+"' ", baglanti);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        int counter,i,j;
        string holder;

        private void Form2_Load(object sender, EventArgs e)
        {
         
            listele();
            listele2();
            
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
                /* foreach (var item in checkedListBox1.CheckedItems)
                 {
                     if (item.Equals("Small"))

                     {
                         holder = textBox1.Text + "1" + "1";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button3.Text + "','" + textBox5.Text + "','"+item.ToString() +"','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }

                     if (item.Equals("Medium"))
                     {
                         holder = textBox1.Text + "1" + "2";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button3.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     if (item.Equals("Large"))
                     {
                         holder = textBox1.Text + "1" + "3";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button3.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     if (item.Equals("XLarge"))
                     {
                         holder = textBox1.Text + "1" + "4";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button3.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     if (item.Equals("XXL"))
                     {
                         holder = textBox1.Text + "1" + "5";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button3.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                 }
                 foreach (var item in checkedListBox2.CheckedItems)
                 {
                     if (item.Equals("Small"))

                     {
                         holder = textBox1.Text + "2" + "1";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button7.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }

                     if (item.Equals("Medium"))
                     {
                         holder = textBox1.Text + "2" + "2";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button7.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     if (item.Equals("Large"))
                     {
                         holder = textBox1.Text + "2" + "3";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button7.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     if (item.Equals("XLarge"))
                     {
                         holder = textBox1.Text + "2" + "4";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button7.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     if (item.Equals("XXL"))
                     {
                         holder = textBox1.Text + "2" + "5";

                         SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + button7.Text + "','" + textBox5.Text + "','" + item.ToString() + "','" + holder + "')", baglanti);
                         komut.ExecuteNonQuery();
                     }
                 }*/
                /* for(i = 0; i < dataGridView2.Rows.Count; i++)
                  {
                     for( j = 1; i < dataGridView2.Rows.Count; j++) { 
                      if (dataGridView2.CurrentRow.Cells[i].Selected)
                      {
                          SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('" + textBox1.Text + "','" + textBox2.Text + "' ,' " + dataGridView2.Rows.ToString() + "','" + textBox5.Text + "','" +  + "','" + holder + "')", baglanti);
                          komut.ExecuteNonQuery();
                      }
                      }
                  }*/
                for (j = 0; j < dataGridView2.RowCount; j++)
                {
                    for (i = 1; i < dataGridView2.ColumnCount; i++)
                    {
                        if ((bool)dataGridView2.Rows[j].Cells[i].EditedFormattedValue)
                        {
                            holder =textBox1.Text+j+i;
                                //dataGridView2.CurrentRow.Index+dataGridView2.CurrentCell.ColumnIndex 
                            SqlCommand komut = new SqlCommand("insert into urunler( urun_kodu,urun_ismi,urun_rengi,urun_fiyat,urun_beden,urun_id) values ('"+ textBox1.Text +"','"+ textBox2.Text +"' ,' " +dataGridView2.Rows[j].Cells[0].Value.ToString() +"','" + textBox5.Text + "','"+ dataGridView2.Columns[i].Name.ToString() +"','"+ holder +"')", baglanti);
                            komut.ExecuteNonQuery();
                            //listBox1.Items.Add(dataGridView1.Rows[j].Cells[0].Value.ToString() + dataGridView1.Columns[i].Name.ToString());
                        }
                            
                    }
                    // listBox1.Items.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString() + dataGridView1.Columns[j].Name.ToString());
                    // dataGridView1.Columns[1].Name dataGridView1.CurrentRow.Cells[i].Value.ToString() +
                }
            

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
        public void listele2()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from colors", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

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
