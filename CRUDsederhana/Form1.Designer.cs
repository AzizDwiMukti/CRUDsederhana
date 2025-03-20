namespace CRUDsederhana
{
    partial class Form1
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
            this.NIM = new System.Windows.Forms.Label();
            this.NAMA = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.TELEPHONE = new System.Windows.Forms.Label();
            this.ALAMAT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TAMBAH = new System.Windows.Forms.Button();
            this.HAPUS = new System.Windows.Forms.Button();
            this.UBAH = new System.Windows.Forms.Button();
            this.REFRESH = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(47, 53);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(38, 20);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            this.NIM.Click += new System.EventHandler(this.label1_Click);
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.Location = new System.Drawing.Point(47, 89);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(55, 20);
            this.NAMA.TabIndex = 1;
            this.NAMA.Text = "NAMA";
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(44, 177);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(58, 20);
            this.EMAIL.TabIndex = 2;
            this.EMAIL.Text = "EMAIL";
            // 
            // TELEPHONE
            // 
            this.TELEPHONE.AutoSize = true;
            this.TELEPHONE.Location = new System.Drawing.Point(44, 219);
            this.TELEPHONE.Name = "TELEPHONE";
            this.TELEPHONE.Size = new System.Drawing.Size(105, 20);
            this.TELEPHONE.TabIndex = 3;
            this.TELEPHONE.Text = "TELEPHONE";
            this.TELEPHONE.Click += new System.EventHandler(this.TELEPHONE_Click);
            // 
            // ALAMAT
            // 
            this.ALAMAT.AutoSize = true;
            this.ALAMAT.Location = new System.Drawing.Point(47, 135);
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(73, 20);
            this.ALAMAT.TabIndex = 4;
            this.ALAMAT.Text = "ALAMAT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(319, 26);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(234, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(319, 26);
            this.textBox5.TabIndex = 9;
            // 
            // TAMBAH
            // 
            this.TAMBAH.Location = new System.Drawing.Point(642, 63);
            this.TAMBAH.Name = "TAMBAH";
            this.TAMBAH.Size = new System.Drawing.Size(104, 40);
            this.TAMBAH.TabIndex = 10;
            this.TAMBAH.Text = "Tambah";
            this.TAMBAH.UseVisualStyleBackColor = true;
            this.TAMBAH.Click += new System.EventHandler(this.TAMBAH_Click);
            // 
            // HAPUS
            // 
            this.HAPUS.Location = new System.Drawing.Point(642, 109);
            this.HAPUS.Name = "HAPUS";
            this.HAPUS.Size = new System.Drawing.Size(104, 39);
            this.HAPUS.TabIndex = 11;
            this.HAPUS.Text = "HAPUS";
            this.HAPUS.UseVisualStyleBackColor = true;
            this.HAPUS.Click += new System.EventHandler(this.button2_Click);
            // 
            // UBAH
            // 
            this.UBAH.Location = new System.Drawing.Point(642, 154);
            this.UBAH.Name = "UBAH";
            this.UBAH.Size = new System.Drawing.Size(104, 38);
            this.UBAH.TabIndex = 12;
            this.UBAH.Text = "UBAH";
            this.UBAH.UseVisualStyleBackColor = true;
            this.UBAH.Click += new System.EventHandler(this.button3_Click);
            // 
            // REFRESH
            // 
            this.REFRESH.Location = new System.Drawing.Point(642, 198);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(104, 41);
            this.REFRESH.TabIndex = 13;
            this.REFRESH.Text = "REFRESH";
            this.REFRESH.UseVisualStyleBackColor = true;
            this.REFRESH.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(48, 273);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 62;
            this.dgvMahasiswa.RowTemplate.Height = 28;
            this.dgvMahasiswa.Size = new System.Drawing.Size(698, 150);
            this.dgvMahasiswa.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.UBAH);
            this.Controls.Add(this.HAPUS);
            this.Controls.Add(this.TAMBAH);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.TELEPHONE);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label TELEPHONE;
        private System.Windows.Forms.Label ALAMAT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button TAMBAH;
        private System.Windows.Forms.Button HAPUS;
        private System.Windows.Forms.Button UBAH;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

