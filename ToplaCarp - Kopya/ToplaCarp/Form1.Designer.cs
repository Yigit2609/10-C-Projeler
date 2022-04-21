namespace ToplaCarp
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
            this.rdTopla = new System.Windows.Forms.RadioButton();
            this.rdCarp = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCarp);
            this.groupBox1.Controls.Add(this.rdTopla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(541, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemi Seç";
            // 
            // rdTopla
            // 
            this.rdTopla.AutoSize = true;
            this.rdTopla.Checked = true;
            this.rdTopla.Location = new System.Drawing.Point(24, 46);
            this.rdTopla.Name = "rdTopla";
            this.rdTopla.Size = new System.Drawing.Size(214, 33);
            this.rdTopla.TabIndex = 0;
            this.rdTopla.TabStop = true;
            this.rdTopla.Text = "Toplama İşlemi";
            this.rdTopla.UseVisualStyleBackColor = true;
            // 
            // rdCarp
            // 
            this.rdCarp.AutoSize = true;
            this.rdCarp.Location = new System.Drawing.Point(296, 46);
            this.rdCarp.Name = "rdCarp";
            this.rdCarp.Size = new System.Drawing.Size(202, 33);
            this.rdCarp.TabIndex = 1;
            this.rdCarp.TabStop = true;
            this.rdCarp.Text = "Çarpma İşlemi";
            this.rdCarp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.Sayı";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(170, 140);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(375, 34);
            this.txtS1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(170, 190);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(375, 34);
            this.txtS2.TabIndex = 2;
            // 
            // btnIslem
            // 
            this.btnIslem.ForeColor = System.Drawing.Color.Maroon;
            this.btnIslem.Location = new System.Drawing.Point(170, 230);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(375, 58);
            this.btnIslem.TabIndex = 3;
            this.btnIslem.Text = "İşlemi Yap";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(41, 312);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(120, 29);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Sonuç = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(584, 398);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCarp;
        private System.Windows.Forms.RadioButton rdTopla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label lblSonuc;
    }
}

