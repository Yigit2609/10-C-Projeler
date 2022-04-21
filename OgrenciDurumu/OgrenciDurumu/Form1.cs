using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrenciDurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, tutar;
            fiyat =Convert.ToDouble( textBox1.Text);

            if (radioButton1.Checked)
            {
                tutar = fiyat * 1.18;
                label3.Text = tutar.ToString()+" TL";
            }
            else {
                tutar = fiyat * 1.08;
                label3.Text = tutar.ToString() + " TL";
            }
        }
    }
}
