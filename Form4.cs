using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace MyS_Proje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BF37VJF;Initial Catalog=MyS;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e){ listele(); }
        public void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from urunler ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.label1.Text,this.label1.Font,Brushes.Black,50,50);
            e.Graphics.DrawString(this.label2.Text, this.label2.Font, Brushes.Black, 150, 50);
            e.Graphics.DrawString(this.label3.Text, this.label4.Font, Brushes.Black, 50, 100);
            e.Graphics.DrawString(this.label4.Text, this.label4.Font, Brushes.Black, 100, 100);
            e.Graphics.DrawString("TL",new Font("Ariel",12,FontStyle.Regular),Brushes.Black,200,100);
            e.Graphics.DrawImage(this.pictureBox1.Image,75,150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             label2.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
             label3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             label4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(label1.Text, 20);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog(); 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from urunler where urun_kodu like '%" + textBox1.Text + "%' or urun_ismi like '%" + textBox1.Text + "%' ", baglanti);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(label1.Text, 20);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
    }
}
