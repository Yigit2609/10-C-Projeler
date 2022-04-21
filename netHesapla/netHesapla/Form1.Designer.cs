namespace netHesapla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlıs = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtMatDogru = new System.Windows.Forms.TextBox();
            this.txtMatNet = new System.Windows.Forms.TextBox();
            this.txtMatYanlıs = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.txtMatNet);
            this.groupBox1.Controls.Add(this.txtTurkceNet);
            this.groupBox1.Controls.Add(this.txtMatDogru);
            this.groupBox1.Controls.Add(this.txtMatYanlıs);
            this.groupBox1.Controls.Add(this.txtTurkceYanlıs);
            this.groupBox1.Controls.Add(this.txtTurkceDogru);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav (1.Oturum)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜRKÇE (40 SORU)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATEMATİK(40 SORU)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOĞRU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "YANLIŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "NET";
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(300, 58);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(57, 22);
            this.txtTurkceDogru.TabIndex = 5;
            // 
            // txtTurkceYanlıs
            // 
            this.txtTurkceYanlıs.Location = new System.Drawing.Point(383, 58);
            this.txtTurkceYanlıs.Name = "txtTurkceYanlıs";
            this.txtTurkceYanlıs.Size = new System.Drawing.Size(57, 22);
            this.txtTurkceYanlıs.TabIndex = 5;
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Enabled = false;
            this.txtTurkceNet.Location = new System.Drawing.Point(466, 58);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.Size = new System.Drawing.Size(57, 22);
            this.txtTurkceNet.TabIndex = 5;
            // 
            // txtMatDogru
            // 
            this.txtMatDogru.Location = new System.Drawing.Point(300, 98);
            this.txtMatDogru.Name = "txtMatDogru";
            this.txtMatDogru.Size = new System.Drawing.Size(57, 22);
            this.txtMatDogru.TabIndex = 5;
            // 
            // txtMatNet
            // 
            this.txtMatNet.Enabled = false;
            this.txtMatNet.Location = new System.Drawing.Point(466, 98);
            this.txtMatNet.Name = "txtMatNet";
            this.txtMatNet.Size = new System.Drawing.Size(57, 22);
            this.txtMatNet.TabIndex = 5;
            // 
            // txtMatYanlıs
            // 
            this.txtMatYanlıs.Location = new System.Drawing.Point(383, 98);
            this.txtMatYanlıs.Name = "txtMatYanlıs";
            this.txtMatYanlıs.Size = new System.Drawing.Size(57, 22);
            this.txtMatYanlıs.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(320, 154);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(162, 43);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "NET HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(554, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtMatNet;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.TextBox txtMatDogru;
        private System.Windows.Forms.TextBox txtMatYanlıs;
        private System.Windows.Forms.TextBox txtTurkceYanlıs;
        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

