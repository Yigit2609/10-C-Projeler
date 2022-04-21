namespace Indirim
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
            this.txtEtiketFiyati = new System.Windows.Forms.TextBox();
            this.btnYuzde15 = new System.Windows.Forms.Button();
            this.btnYuzde25 = new System.Windows.Forms.Button();
            this.btnYuzde50 = new System.Windows.Forms.Button();
            this.btnYuzde75 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.txtEtiketFiyati);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiket Fiyatı";
            // 
            // txtEtiketFiyati
            // 
            this.txtEtiketFiyati.Location = new System.Drawing.Point(190, 15);
            this.txtEtiketFiyati.Name = "txtEtiketFiyati";
            this.txtEtiketFiyati.Size = new System.Drawing.Size(239, 38);
            this.txtEtiketFiyati.TabIndex = 1;
            // 
            // btnYuzde15
            // 
            this.btnYuzde15.BackColor = System.Drawing.Color.Pink;
            this.btnYuzde15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde15.Location = new System.Drawing.Point(64, 106);
            this.btnYuzde15.Name = "btnYuzde15";
            this.btnYuzde15.Size = new System.Drawing.Size(101, 89);
            this.btnYuzde15.TabIndex = 1;
            this.btnYuzde15.Text = "%15 İndirim";
            this.btnYuzde15.UseVisualStyleBackColor = false;
            this.btnYuzde15.Click += new System.EventHandler(this.btnYuzde15_Click);
            // 
            // btnYuzde25
            // 
            this.btnYuzde25.BackColor = System.Drawing.Color.LightSalmon;
            this.btnYuzde25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde25.Location = new System.Drawing.Point(172, 106);
            this.btnYuzde25.Name = "btnYuzde25";
            this.btnYuzde25.Size = new System.Drawing.Size(101, 89);
            this.btnYuzde25.TabIndex = 1;
            this.btnYuzde25.Text = "%25 İndirim";
            this.btnYuzde25.UseVisualStyleBackColor = false;
            this.btnYuzde25.Click += new System.EventHandler(this.btnYuzde25_Click);
            // 
            // btnYuzde50
            // 
            this.btnYuzde50.BackColor = System.Drawing.Color.Salmon;
            this.btnYuzde50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde50.Location = new System.Drawing.Point(281, 106);
            this.btnYuzde50.Name = "btnYuzde50";
            this.btnYuzde50.Size = new System.Drawing.Size(101, 89);
            this.btnYuzde50.TabIndex = 1;
            this.btnYuzde50.Text = "%50 İndirim";
            this.btnYuzde50.UseVisualStyleBackColor = false;
            this.btnYuzde50.Click += new System.EventHandler(this.btnYuzde50_Click);
            // 
            // btnYuzde75
            // 
            this.btnYuzde75.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYuzde75.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde75.Location = new System.Drawing.Point(388, 106);
            this.btnYuzde75.Name = "btnYuzde75";
            this.btnYuzde75.Size = new System.Drawing.Size(101, 89);
            this.btnYuzde75.TabIndex = 1;
            this.btnYuzde75.Text = "%75 İndirim";
            this.btnYuzde75.UseVisualStyleBackColor = false;
            this.btnYuzde75.Click += new System.EventHandler(this.btnYuzde75_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblFiyat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(64, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "İndirimli Fiyat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFiyat.ForeColor = System.Drawing.Color.Black;
            this.lblFiyat.Location = new System.Drawing.Point(109, 48);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(219, 39);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "0";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnYuzde75);
            this.Controls.Add(this.btnYuzde50);
            this.Controls.Add(this.btnYuzde25);
            this.Controls.Add(this.btnYuzde15);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEtiketFiyati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYuzde15;
        private System.Windows.Forms.Button btnYuzde25;
        private System.Windows.Forms.Button btnYuzde50;
        private System.Windows.Forms.Button btnYuzde75;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label2;
    }
}

