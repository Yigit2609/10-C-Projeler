using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekiller
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dikdortgen dik = new Dikdortgen();
            dik.A = 5;
            dik.B = 3;

            MessageBox.Show("Alan:"+dik.AlanHesapla());
            MessageBox.Show("Çevresi:" + dik.CevreHesapla());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();

            t.Left = 200;
            t.Top = 200;
            t.Width = 100;
            t.Height = 20;

            Controls.Add(t);
        }
    }








    class Dikdortgen
    {
        private int a;//Field (Alan)
        private int b;//Field (Alan)


        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int AlanHesapla()
        {
            return a * b;
        }

        public int CevreHesapla()
        {
            return (a + b) * 2;
        }
    }
}
