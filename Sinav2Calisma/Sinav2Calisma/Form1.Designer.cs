namespace Sinav2Calisma
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
            this.btnTumuBuyuk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTumunuKucult = new System.Windows.Forms.Button();
            this.btnKelimeDuzeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTumuBuyuk
            // 
            this.btnTumuBuyuk.Location = new System.Drawing.Point(63, 104);
            this.btnTumuBuyuk.Name = "btnTumuBuyuk";
            this.btnTumuBuyuk.Size = new System.Drawing.Size(270, 46);
            this.btnTumuBuyuk.TabIndex = 0;
            this.btnTumuBuyuk.Text = "Tümünü Büyüt";
            this.btnTumuBuyuk.UseVisualStyleBackColor = true;
            this.btnTumuBuyuk.Click += new System.EventHandler(this.btnTumuBuyuk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(63, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(722, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Torbalı Mesleki Ve Teknik Anadolu Lisesi";
            // 
            // btnTumunuKucult
            // 
            this.btnTumunuKucult.Location = new System.Drawing.Point(63, 156);
            this.btnTumunuKucult.Name = "btnTumunuKucult";
            this.btnTumunuKucult.Size = new System.Drawing.Size(270, 46);
            this.btnTumunuKucult.TabIndex = 0;
            this.btnTumunuKucult.Text = "Tümünü Küçült";
            this.btnTumunuKucult.UseVisualStyleBackColor = true;
            this.btnTumunuKucult.Click += new System.EventHandler(this.btnTumunuKucult_Click);
            // 
            // btnKelimeDuzeni
            // 
            this.btnKelimeDuzeni.Location = new System.Drawing.Point(63, 208);
            this.btnKelimeDuzeni.Name = "btnKelimeDuzeni";
            this.btnKelimeDuzeni.Size = new System.Drawing.Size(270, 46);
            this.btnKelimeDuzeni.TabIndex = 0;
            this.btnKelimeDuzeni.Text = "Kelime Duzeni";
            this.btnKelimeDuzeni.UseVisualStyleBackColor = true;
            this.btnKelimeDuzeni.Click += new System.EventHandler(this.btnKelimeDuzeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 452);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKelimeDuzeni);
            this.Controls.Add(this.btnTumunuKucult);
            this.Controls.Add(this.btnTumuBuyuk);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTumuBuyuk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTumunuKucult;
        private System.Windows.Forms.Button btnKelimeDuzeni;
    }
}

