namespace Kuvvet10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSayilarFor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGosterFor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGosterWhile = new System.Windows.Forms.Button();
            this.lbSayilarWhile = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGosterDoWhile = new System.Windows.Forms.Button();
            this.lbSayilarDoWhile = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Döngüler";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btnGosterFor);
            this.groupBox1.Controls.Add(this.lbSayilarFor);
            this.groupBox1.Location = new System.Drawing.Point(32, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "for Döngüsü";
            // 
            // lbSayilarFor
            // 
            this.lbSayilarFor.FormattingEnabled = true;
            this.lbSayilarFor.ItemHeight = 29;
            this.lbSayilarFor.Location = new System.Drawing.Point(27, 46);
            this.lbSayilarFor.Name = "lbSayilarFor";
            this.lbSayilarFor.Size = new System.Drawing.Size(221, 207);
            this.lbSayilarFor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(950, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bu örnekte 10 sayısının 0\'dan 5\'e kadar olan kuvvetleri listbox içerisine eklenir" +
                ".";
            // 
            // btnGosterFor
            // 
            this.btnGosterFor.Location = new System.Drawing.Point(27, 259);
            this.btnGosterFor.Name = "btnGosterFor";
            this.btnGosterFor.Size = new System.Drawing.Size(221, 44);
            this.btnGosterFor.TabIndex = 1;
            this.btnGosterFor.Text = "Göster";
            this.btnGosterFor.UseVisualStyleBackColor = true;
            this.btnGosterFor.Click += new System.EventHandler(this.btnGosterFor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.btnGosterWhile);
            this.groupBox2.Controls.Add(this.lbSayilarWhile);
            this.groupBox2.Location = new System.Drawing.Point(369, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 309);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "while Döngüsü";
            // 
            // btnGosterWhile
            // 
            this.btnGosterWhile.Location = new System.Drawing.Point(27, 259);
            this.btnGosterWhile.Name = "btnGosterWhile";
            this.btnGosterWhile.Size = new System.Drawing.Size(221, 44);
            this.btnGosterWhile.TabIndex = 1;
            this.btnGosterWhile.Text = "Göster";
            this.btnGosterWhile.UseVisualStyleBackColor = true;
            this.btnGosterWhile.Click += new System.EventHandler(this.btnGosterWhile_Click);
            // 
            // lbSayilarWhile
            // 
            this.lbSayilarWhile.FormattingEnabled = true;
            this.lbSayilarWhile.ItemHeight = 29;
            this.lbSayilarWhile.Location = new System.Drawing.Point(27, 46);
            this.lbSayilarWhile.Name = "lbSayilarWhile";
            this.lbSayilarWhile.Size = new System.Drawing.Size(221, 207);
            this.lbSayilarWhile.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Plum;
            this.groupBox3.Controls.Add(this.btnGosterDoWhile);
            this.groupBox3.Controls.Add(this.lbSayilarDoWhile);
            this.groupBox3.Location = new System.Drawing.Point(709, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 310);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "do-while Döngüsü";
            // 
            // btnGosterDoWhile
            // 
            this.btnGosterDoWhile.Location = new System.Drawing.Point(27, 259);
            this.btnGosterDoWhile.Name = "btnGosterDoWhile";
            this.btnGosterDoWhile.Size = new System.Drawing.Size(221, 44);
            this.btnGosterDoWhile.TabIndex = 1;
            this.btnGosterDoWhile.Text = "Göster";
            this.btnGosterDoWhile.UseVisualStyleBackColor = true;
            this.btnGosterDoWhile.Click += new System.EventHandler(this.btnGosterDoWhile_Click);
            // 
            // lbSayilarDoWhile
            // 
            this.lbSayilarDoWhile.FormattingEnabled = true;
            this.lbSayilarDoWhile.ItemHeight = 29;
            this.lbSayilarDoWhile.Location = new System.Drawing.Point(27, 46);
            this.lbSayilarDoWhile.Name = "lbSayilarDoWhile";
            this.lbSayilarDoWhile.Size = new System.Drawing.Size(221, 207);
            this.lbSayilarDoWhile.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGosterFor;
        private System.Windows.Forms.ListBox lbSayilarFor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGosterWhile;
        private System.Windows.Forms.ListBox lbSayilarWhile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGosterDoWhile;
        private System.Windows.Forms.ListBox lbSayilarDoWhile;
    }
}

