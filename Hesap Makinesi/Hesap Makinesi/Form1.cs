using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Hesap makine = new Hesap();
        //Rakam Butonları******************************
        private void button1_Click(object sender, EventArgs e)
        {
            if (makine.EsittireBasildimi) {
                textBox1.Clear();
            }
            string text = textBox1.Text;
            text = text + this.ActiveControl .Text;
            textBox1.Text = text;
            
        }
        //************************************************
        //İşlem Butonları*****************************
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                makine.sayi1 = double.Parse(textBox1.Text);
                makine.sembol = char.Parse(this.ActiveControl.Text);
                textBox1.Clear();
            }
        }
        //*******************************************************************
        //Eşittir Butonu
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && makine.sembol!=' ')
            {
                makine.sayi2 = double.Parse(textBox1.Text);
                textBox1.Text = makine.HesapYap();
                makine.EsittireBasildimi = true;
                makine.sayi1 = double.Parse(textBox1.Text);
                makine.sembol = ' ';
            }
        }
        //*****************************************************************************
        //Nokta butonu
        private void button10_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == "")
            {
                text += "0,";
                textBox1.Text = text;
            }

            if (!text.Contains(",")) {
                text += ",";
                textBox1.Text = text;
            }
           //******************************************************** 
            
        }
    }
}
