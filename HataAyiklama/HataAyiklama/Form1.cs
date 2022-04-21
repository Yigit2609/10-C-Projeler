using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HataAyiklama
{
    public partial class Form1 : Ata
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sonuc;

         

            try
            {
                int s1 = Convert.ToInt32(txtS1.Text);
                int s2 = Convert.ToInt32(txtS2.Text);
                sonuc = s1 + s2;
            }
            catch
            {
                MessageBox.Show("Bir hata var!");
                return;
            }
            finally
            {
                txtS1.Text = "";
                txtS2.Text = "";
            }


            MessageBox.Show("Sayıların Toplamı:" + sonuc);

            int  i = 5;
            do
            {

            } while (i < 3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            try
            {
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                s3 = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Hata Var!");
                return;
            }

            if (s1 > s2 && s1 > s3)
                MessageBox.Show("s1 en büyük");
            else if (s2 > s1 && s2 > s3)
                MessageBox.Show("s2 en büyük");
            else if (s3 > s1 && s3 > s2)
                MessageBox.Show("s3 en büyük");
            else MessageBox.Show("Bazı sayılar eşit!");
        }
    }
}
