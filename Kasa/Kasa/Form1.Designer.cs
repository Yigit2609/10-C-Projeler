namespace Kasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTekCekim = new System.Windows.Forms.RadioButton();
            this.rd2Taksit = new System.Windows.Forms.RadioButton();
            this.rd3Taksit = new System.Windows.Forms.RadioButton();
            this.rd4Taksit = new System.Windows.Forms.RadioButton();
            this.rd5Taksit = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnGecmisTemizle = new System.Windows.Forms.Button();
            this.lbGecmis = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.BackColor = System.Drawing.Color.Salmon;
            this.txtTutar.Location = new System.Drawing.Point(220, 31);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(208, 38);
            this.txtTutar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.rd5Taksit);
            this.groupBox1.Controls.Add(this.rd4Taksit);
            this.groupBox1.Controls.Add(this.rd3Taksit);
            this.groupBox1.Controls.Add(this.rd2Taksit);
            this.groupBox1.Controls.Add(this.rdTekCekim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(39, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(389, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Seçenekleri";
            // 
            // rdTekCekim
            // 
            this.rdTekCekim.AutoSize = true;
            this.rdTekCekim.Location = new System.Drawing.Point(56, 68);
            this.rdTekCekim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdTekCekim.Name = "rdTekCekim";
            this.rdTekCekim.Size = new System.Drawing.Size(165, 35);
            this.rdTekCekim.TabIndex = 0;
            this.rdTekCekim.TabStop = true;
            this.rdTekCekim.Text = "Tek Çekim";
            this.rdTekCekim.UseVisualStyleBackColor = true;
            // 
            // rd2Taksit
            // 
            this.rd2Taksit.AutoSize = true;
            this.rd2Taksit.Location = new System.Drawing.Point(56, 120);
            this.rd2Taksit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rd2Taksit.Name = "rd2Taksit";
            this.rd2Taksit.Size = new System.Drawing.Size(301, 35);
            this.rd2Taksit.TabIndex = 0;
            this.rd2Taksit.TabStop = true;
            this.rd2Taksit.Text = "2 Taksit (%5 Ek Fiyat)";
            this.rd2Taksit.UseVisualStyleBackColor = true;
            // 
            // rd3Taksit
            // 
            this.rd3Taksit.AutoSize = true;
            this.rd3Taksit.Location = new System.Drawing.Point(56, 172);
            this.rd3Taksit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rd3Taksit.Name = "rd3Taksit";
            this.rd3Taksit.Size = new System.Drawing.Size(301, 35);
            this.rd3Taksit.TabIndex = 0;
            this.rd3Taksit.TabStop = true;
            this.rd3Taksit.Text = "3 Taksit (%5 Ek Fiyat)";
            this.rd3Taksit.UseVisualStyleBackColor = true;
            // 
            // rd4Taksit
            // 
            this.rd4Taksit.AutoSize = true;
            this.rd4Taksit.Location = new System.Drawing.Point(56, 225);
            this.rd4Taksit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rd4Taksit.Name = "rd4Taksit";
            this.rd4Taksit.Size = new System.Drawing.Size(316, 35);
            this.rd4Taksit.TabIndex = 0;
            this.rd4Taksit.TabStop = true;
            this.rd4Taksit.Text = "4 Taksit (%10 Ek Fiyat)";
            this.rd4Taksit.UseVisualStyleBackColor = true;
            // 
            // rd5Taksit
            // 
            this.rd5Taksit.AutoSize = true;
            this.rd5Taksit.Location = new System.Drawing.Point(56, 277);
            this.rd5Taksit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rd5Taksit.Name = "rd5Taksit";
            this.rd5Taksit.Size = new System.Drawing.Size(316, 35);
            this.rd5Taksit.TabIndex = 0;
            this.rd5Taksit.TabStop = true;
            this.rd5Taksit.Text = "5 Taksit (%10 Ek Fiyat)";
            this.rd5Taksit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.lbGecmis);
            this.groupBox2.Location = new System.Drawing.Point(437, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 344);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Geçmişi";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(39, 450);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(389, 62);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnGecmisTemizle
            // 
            this.btnGecmisTemizle.Location = new System.Drawing.Point(688, 450);
            this.btnGecmisTemizle.Name = "btnGecmisTemizle";
            this.btnGecmisTemizle.Size = new System.Drawing.Size(242, 62);
            this.btnGecmisTemizle.TabIndex = 4;
            this.btnGecmisTemizle.Text = "Geçmişi Temizle";
            this.btnGecmisTemizle.UseVisualStyleBackColor = true;
            this.btnGecmisTemizle.Click += new System.EventHandler(this.btnGecmisTemizle_Click);
            // 
            // lbGecmis
            // 
            this.lbGecmis.FormattingEnabled = true;
            this.lbGecmis.ItemHeight = 31;
            this.lbGecmis.Location = new System.Drawing.Point(17, 55);
            this.lbGecmis.Name = "lbGecmis";
            this.lbGecmis.Size = new System.Drawing.Size(454, 283);
            this.lbGecmis.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 542);
            this.Controls.Add(this.btnGecmisTemizle);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd5Taksit;
        private System.Windows.Forms.RadioButton rd4Taksit;
        private System.Windows.Forms.RadioButton rd3Taksit;
        private System.Windows.Forms.RadioButton rd2Taksit;
        private System.Windows.Forms.RadioButton rdTekCekim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbGecmis;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnGecmisTemizle;
    }
}

