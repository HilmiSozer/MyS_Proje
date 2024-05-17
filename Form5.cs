﻿using System;
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

            textBox2.Focus();   


        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        int satir = 0;
        int i,fiyat;
        int holder = 50;
        int price = 0;
        string temp;
        string temp2 ;
        SqlCommand yenistok;

        SqlDataReader ekle;
        SqlDataReader stok;
        SqlCommand ekleme;
        SqlCommand stoksil;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("My'S TICKET", this.textBox2.Font, Brushes.Black, 350, 0);
            
            e.Graphics.DrawString("URUN KODU ", this.textBox2.Font, Brushes.Black, 75, holder);
            e.Graphics.DrawString("URUN ISMI ", this.textBox2.Font, Brushes.Black, 225, holder);
            e.Graphics.DrawString("URUN BEDEN ", this.textBox2.Font, Brushes.Black, 375, holder);
            e.Graphics.DrawString("URUN FIYAT ", this.textBox2.Font, Brushes.Black, 525, holder );
            e.Graphics.DrawString("URUN RENK ", this.textBox2.Font, Brushes.Black, 675, holder);

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------ ", this.textBox2.Font, Brushes.Black, 200, holder+25);
            for (i = 0; i < dataGridView1.Rows.Count-1;i++)
            {
                
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), this.textBox2.Font, Brushes.Black, 75, holder+50);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), this.textBox2.Font, Brushes.Black, 225, holder+50);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), this.textBox2.Font, Brushes.Black, 375, holder+50);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), this.textBox2.Font, Brushes.Black, 525, holder+50);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), this.textBox2.Font, Brushes.Black, 675, holder + 50);
                holder += 50;
                price +=Convert.ToInt32( dataGridView1.Rows[i].Cells[3].Value) ; 
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------ ", this.textBox2.Font, Brushes.Black, 200, holder+50);
            e.Graphics.DrawString("Toplam Adet :", this.textBox2.Font, Brushes.Black, 500, holder + 100);
            e.Graphics.DrawString(Convert.ToString(dataGridView1.Rows.Count - 1), this.textBox2.Font, Brushes.Black, 600, holder + 100);
            e.Graphics.DrawString("Toplam Fiyat :", this.textBox2.Font, Brushes.Black, 500, holder + 150);
            e.Graphics.DrawString(price.ToString(), this.textBox2.Font, Brushes.Black, 600, holder + 150);

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
             
            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            { baglanti.Open();

                stoksil = new SqlCommand("Select urun_adet from urunler where urun_id like '" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "' ", baglanti);
                stok = stoksil.ExecuteReader();

                while (stok.Read())
                {
                    temp = (stok["urun_adet"].ToString());

                } 
                stok.Close();
            baglanti.Close();
               temp =Convert.ToString(Convert.ToInt32(temp) - 1) ;
                   baglanti.Open() ;
yenistok = new SqlCommand("Update urunler set urun_adet = '"+temp+ "' where urun_id like '" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "'  ", baglanti);
                yenistok.ExecuteNonQuery();
                baglanti.Close();

                if(Convert.ToInt32(temp)<0)
                MessageBox.Show("Stok adeti bulunmyan ürün satıldı.");


                
            }
            
                printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            textBox2.Text = "";
        }

      

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                try
                {
                   
                    baglanti.Open();

                    ekleme = new SqlCommand("select urun_kodu, urun_ismi, urun_beden, urun_fiyat ,urun_rengi,urun_id from urunler where urun_id like '" + textBox2.Text + "'", baglanti);

                    ekle = ekleme.ExecuteReader();

                    while (ekle.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[satir].Cells[0].Value = (ekle["urun_kodu"].ToString());
                        dataGridView1.Rows[satir].Cells[1].Value = (ekle["urun_ismi"].ToString());
                        dataGridView1.Rows[satir].Cells[2].Value = (ekle["urun_beden"].ToString());
                        dataGridView1.Rows[satir].Cells[3].Value = (ekle["urun_fiyat"].ToString());
                        dataGridView1.Rows[satir].Cells[4].Value = (ekle["urun_rengi"].ToString());
                        dataGridView1.Rows[satir].Cells[5].Value = (ekle["urun_id"].ToString());

                       
                        satir++;
                       
                    }
                    ekle.Close();
                    baglanti.Close();
                    label2.Text = satir.ToString();
                    for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        
                        label4.Text ="";
                        temp2 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                       fiyat+= Convert.ToInt32(temp2);
                        label4.Text = fiyat.ToString();

                    }
                    


                }
                finally
                {
                    fiyat= 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
fiyat = 0;

            for (i = 0; i < dataGridView1.Rows.Count-1  ; i++)
            {
                if (dataGridView1.Rows[i].Cells[5].Value == null)
                { }
                else
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            satir--;
                    break;
            
                }

            }
            
            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               
                   label4.Text = "";
                temp2 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                fiyat += Convert.ToInt32(temp2);
                label4.Text = fiyat.ToString();

                label2.Text = satir.ToString();
            }
            }
            
        }
    }

