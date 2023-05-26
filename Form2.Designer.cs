namespace MyS_Proje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new MyS_Proje.MySDataSetTableAdapters.urunlerTableAdapter();
            this.Kayitbuton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new MyS_Proje.MySDataSetTableAdapters.TableAdapterManager();
            this.urunlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter1 = new MyS_Proje.MySDataSet1TableAdapters.urunlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunrengiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunbedenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mySDataSet1 = new MyS_Proje.MySDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // Kayitbuton
            // 
            this.Kayitbuton.Location = new System.Drawing.Point(1028, 647);
            this.Kayitbuton.Name = "Kayitbuton";
            this.Kayitbuton.Size = new System.Drawing.Size(83, 36);
            this.Kayitbuton.TabIndex = 1;
            this.Kayitbuton.Text = "Kayıt";
            this.Kayitbuton.UseVisualStyleBackColor = true;
            this.Kayitbuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(326, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 194);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ÜRÜN FİYATI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(169, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 194);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN İSMİ ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 194);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN KODU ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yeni Kayıt Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(926, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = true;
          
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = MyS_Proje.MySDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.urunlerTableAdapter = this.urunlerTableAdapter;
            // 
            // urunlerTableAdapter1
            // 
            this.urunlerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunismiDataGridViewTextBoxColumn,
            this.urunrengiDataGridViewTextBoxColumn,
            this.urunadetDataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn,
            this.urunbedenDataGridViewTextBoxColumn,
            this.urunidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 348);
            this.dataGridView1.TabIndex = 15;
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urun_kodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "urun_kodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            // 
            // urunismiDataGridViewTextBoxColumn
            // 
            this.urunismiDataGridViewTextBoxColumn.DataPropertyName = "urun_ismi";
            this.urunismiDataGridViewTextBoxColumn.HeaderText = "urun_ismi";
            this.urunismiDataGridViewTextBoxColumn.Name = "urunismiDataGridViewTextBoxColumn";
            // 
            // urunrengiDataGridViewTextBoxColumn
            // 
            this.urunrengiDataGridViewTextBoxColumn.DataPropertyName = "urun_rengi";
            this.urunrengiDataGridViewTextBoxColumn.HeaderText = "urun_rengi";
            this.urunrengiDataGridViewTextBoxColumn.Name = "urunrengiDataGridViewTextBoxColumn";
            // 
            // urunadetDataGridViewTextBoxColumn
            // 
            this.urunadetDataGridViewTextBoxColumn.DataPropertyName = "urun_adet";
            this.urunadetDataGridViewTextBoxColumn.HeaderText = "urun_adet";
            this.urunadetDataGridViewTextBoxColumn.Name = "urunadetDataGridViewTextBoxColumn";
            // 
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            // 
            // urunbedenDataGridViewTextBoxColumn
            // 
            this.urunbedenDataGridViewTextBoxColumn.DataPropertyName = "urun_beden";
            this.urunbedenDataGridViewTextBoxColumn.HeaderText = "urun_beden";
            this.urunbedenDataGridViewTextBoxColumn.Name = "urunbedenDataGridViewTextBoxColumn";
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "urun_id";
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            // 
            // urunlerBindingSource2
            // 
            this.urunlerBindingSource2.DataMember = "urunler";
            this.urunlerBindingSource2.DataSource = this.mySDataSet1;
            // 
            // mySDataSet1
            // 
            this.mySDataSet1.DataSetName = "MySDataSet1";
            this.mySDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(459, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(687, 204);
            this.dataGridView2.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 695);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kayitbuton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Ürün Oluştur";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private MySDataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.Button Kayitbuton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MySDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource urunlerBindingSource1;
        private MySDataSet1TableAdapters.urunlerTableAdapter urunlerTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunismiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunrengiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunbedenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource urunlerBindingSource2;
        private MySDataSet1 mySDataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}