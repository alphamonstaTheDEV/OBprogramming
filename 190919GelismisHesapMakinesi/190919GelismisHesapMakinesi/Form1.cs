﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190919GelismisHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslem.SelectedIndex = 0;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            int sayi1 =Convert.ToInt16( txtSayi1.Text);
            int sayi2 = Convert.ToInt16(txtSayi2.Text);
            decimal sonuc = 0;
            switch (cmbIslem.Text)
            {
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
                case "*": sonuc = sayi1 * sayi2; break;
                case "/": sonuc = (decimal)sayi1 / sayi2; break;
                case "%": sonuc = sayi1 % sayi2; break;
                default:
                    break;
            }
            lblSonuc.Text = "Sonuç : "+sonuc.ToString();
        }
    }
}
