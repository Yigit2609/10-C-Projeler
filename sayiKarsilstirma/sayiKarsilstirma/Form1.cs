using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sayiKarsilstirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 =Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1. Sayı 2. sayıdan büyüktür.");
            }
            else
            {
                MessageBox.Show("2. sayı 1. sayıdan büyüktür.");
            }
        }
    }
}
