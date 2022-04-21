namespace TemzilikListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBir = new System.Windows.Forms.Label();
            this.lblIki = new System.Windows.Forms.Label();
            this.btnTemizlikYapildi = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temizlik Listesi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 426);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnYeni);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.btnEkle);
            this.panel3.Controls.Add(this.txtSoyad);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(244, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 426);
            this.panel3.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 426);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "No";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(144, 34);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(221, 22);
            this.txtNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(144, 62);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(221, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(144, 90);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(221, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(144, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 35);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle/Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(288, 136);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(36, 136);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(77, 35);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizlikYapildi);
            this.groupBox1.Controls.Add(this.lblIki);
            this.groupBox1.Controls.Add(this.lblBir);
            this.groupBox1.Location = new System.Drawing.Point(24, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bu gün Temizlik Yapacaklar";
            // 
            // lblBir
            // 
            this.lblBir.AutoSize = true;
            this.lblBir.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBir.ForeColor = System.Drawing.Color.White;
            this.lblBir.Location = new System.Drawing.Point(43, 36);
            this.lblBir.Name = "lblBir";
            this.lblBir.Size = new System.Drawing.Size(60, 25);
            this.lblBir.TabIndex = 0;
            this.lblBir.Text = "1.Kişi";
            // 
            // lblIki
            // 
            this.lblIki.AutoSize = true;
            this.lblIki.BackColor = System.Drawing.Color.SteelBlue;
            this.lblIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIki.ForeColor = System.Drawing.Color.White;
            this.lblIki.Location = new System.Drawing.Point(43, 75);
            this.lblIki.Name = "lblIki";
            this.lblIki.Size = new System.Drawing.Size(60, 25);
            this.lblIki.TabIndex = 0;
            this.lblIki.Text = "2.Kişi";
            // 
            // btnTemizlikYapildi
            // 
            this.btnTemizlikYapildi.Location = new System.Drawing.Point(48, 119);
            this.btnTemizlikYapildi.Name = "btnTemizlikYapildi";
            this.btnTemizlikYapildi.Size = new System.Drawing.Size(293, 29);
            this.btnTemizlikYapildi.TabIndex = 1;
            this.btnTemizlikYapildi.Text = "Temizlik Yapıldı";
            this.btnTemizlikYapildi.UseVisualStyleBackColor = true;
            this.btnTemizlikYapildi.Click += new System.EventHandler(this.btnTemizlikYapildi_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(478, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(164, 36);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIki;
        private System.Windows.Forms.Label lblBir;
        private System.Windows.Forms.Button btnTemizlikYapildi;
        private System.Windows.Forms.Button btnKaydet;
    }
}

