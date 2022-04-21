using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ÜcgeninAlanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("Ehliyet alabilirsin.", "Ehliyet Sorgu sonucu");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayi1 ;
            sayi1 = Convert.ToInt32(textBox1.Text);
            
            if (sayi1%2==0)
            { MessageBox.Show("Çifttir"); }
           if (sayi1%2==1)
            { MessageBox.Show("Tektir"); }
        }
    }
}
