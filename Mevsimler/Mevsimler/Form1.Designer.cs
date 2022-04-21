namespace Mevsimler
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDerece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.pbKis = new System.Windows.Forms.PictureBox();
            this.pbSonbahar = new System.Windows.Forms.PictureBox();
            this.pbYaz = new System.Windows.Forms.PictureBox();
            this.pbIlkBahar = new System.Windows.Forms.PictureBox();
            this.pbSonuc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonbahar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIlkBahar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEVSİMLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hava Sıcaklığı";
            // 
            // txtDerece
            // 
            this.txtDerece.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDerece.Location = new System.Drawing.Point(212, 78);
            this.txtDerece.Name = "txtDerece";
            this.txtDerece.Size = new System.Drawing.Size(142, 34);
            this.txtDerece.TabIndex = 2;
            this.txtDerece.TextChanged += new System.EventHandler(this.txtDerece_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(369, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "C°";
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Orange;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(432, 71);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(154, 54);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pbKis);
            this.panel2.Controls.Add(this.pbSonbahar);
            this.panel2.Controls.Add(this.pbYaz);
            this.panel2.Controls.Add(this.pbIlkBahar);
            this.panel2.Controls.Add(this.pbSonuc);
            this.panel2.Controls.Add(this.lblSonuc);
            this.panel2.Location = new System.Drawing.Point(28, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 345);
            this.panel2.TabIndex = 4;
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSonuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Orange;
            this.lblSonuc.Location = new System.Drawing.Point(0, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(780, 39);
            this.lblSonuc.TabIndex = 0;
            this.lblSonuc.Text = "Hangi Mevsim";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSonuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbKis
            // 
            this.pbKis.Image = global::Mevsimler.Properties.Resources.kis;
            this.pbKis.Location = new System.Drawing.Point(20, 265);
            this.pbKis.Name = "pbKis";
            this.pbKis.Size = new System.Drawing.Size(100, 50);
            this.pbKis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKis.TabIndex = 5;
            this.pbKis.TabStop = false;
            this.pbKis.Visible = false;
            // 
            // pbSonbahar
            // 
            this.pbSonbahar.Image = global::Mevsimler.Properties.Resources.sonbahar;
            this.pbSonbahar.Location = new System.Drawing.Point(20, 208);
            this.pbSonbahar.Name = "pbSonbahar";
            this.pbSonbahar.Size = new System.Drawing.Size(100, 50);
            this.pbSonbahar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSonbahar.TabIndex = 4;
            this.pbSonbahar.TabStop = false;
            this.pbSonbahar.Visible = false;
            // 
            // pbYaz
            // 
            this.pbYaz.Image = global::Mevsimler.Properties.Resources.yaz;
            this.pbYaz.Location = new System.Drawing.Point(20, 151);
            this.pbYaz.Name = "pbYaz";
            this.pbYaz.Size = new System.Drawing.Size(100, 50);
            this.pbYaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYaz.TabIndex = 3;
            this.pbYaz.TabStop = false;
            this.pbYaz.Visible = false;
            // 
            // pbIlkBahar
            // 
            this.pbIlkBahar.Image = global::Mevsimler.Properties.Resources.ilkbahar;
            this.pbIlkBahar.Location = new System.Drawing.Point(20, 94);
            this.pbIlkBahar.Name = "pbIlkBahar";
            this.pbIlkBahar.Size = new System.Drawing.Size(100, 50);
            this.pbIlkBahar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIlkBahar.TabIndex = 2;
            this.pbIlkBahar.TabStop = false;
            this.pbIlkBahar.Visible = false;
            // 
            // pbSonuc
            // 
            this.pbSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSonuc.Location = new System.Drawing.Point(0, 39);
            this.pbSonuc.Name = "pbSonuc";
            this.pbSonuc.Size = new System.Drawing.Size(780, 306);
            this.pbSonuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSonuc.TabIndex = 1;
            this.pbSonuc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtDerece);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonbahar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIlkBahar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDerece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.PictureBox pbKis;
        private System.Windows.Forms.PictureBox pbSonbahar;
        private System.Windows.Forms.PictureBox pbYaz;
        private System.Windows.Forms.PictureBox pbIlkBahar;
    }
}

