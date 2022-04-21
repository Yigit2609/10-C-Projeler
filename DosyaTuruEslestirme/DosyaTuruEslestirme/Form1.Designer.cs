namespace DosyaTuruEslestirme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lbDosyaUzantisi = new System.Windows.Forms.ListBox();
            this.rdVideo = new System.Windows.Forms.RadioButton();
            this.rdResim = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDosyaUzantisi);
            this.groupBox1.Location = new System.Drawing.Point(46, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Uzantısı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdResim);
            this.groupBox2.Controls.Add(this.rdVideo);
            this.groupBox2.Location = new System.Drawing.Point(325, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Türü";
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(208, 229);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(156, 30);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // lbDosyaUzantisi
            // 
            this.lbDosyaUzantisi.FormattingEnabled = true;
            this.lbDosyaUzantisi.ItemHeight = 16;
            this.lbDosyaUzantisi.Items.AddRange(new object[] {
            "MP4",
            "JPG",
            "MOV",
            "PNG"});
            this.lbDosyaUzantisi.Location = new System.Drawing.Point(16, 21);
            this.lbDosyaUzantisi.Name = "lbDosyaUzantisi";
            this.lbDosyaUzantisi.Size = new System.Drawing.Size(151, 116);
            this.lbDosyaUzantisi.TabIndex = 0;
            // 
            // rdVideo
            // 
            this.rdVideo.AutoSize = true;
            this.rdVideo.Location = new System.Drawing.Point(30, 33);
            this.rdVideo.Name = "rdVideo";
            this.rdVideo.Size = new System.Drawing.Size(119, 21);
            this.rdVideo.TabIndex = 0;
            this.rdVideo.TabStop = true;
            this.rdVideo.Text = "Video Dosyası";
            this.rdVideo.UseVisualStyleBackColor = true;
            // 
            // rdResim
            // 
            this.rdResim.AutoSize = true;
            this.rdResim.Location = new System.Drawing.Point(30, 75);
            this.rdResim.Name = "rdResim";
            this.rdResim.Size = new System.Drawing.Size(122, 21);
            this.rdResim.TabIndex = 1;
            this.rdResim.TabStop = true;
            this.rdResim.Text = "Resim Dosyası";
            this.rdResim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 308);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDosyaUzantisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdResim;
        private System.Windows.Forms.RadioButton rdVideo;
        private System.Windows.Forms.Button btnKontrol;
    }
}

