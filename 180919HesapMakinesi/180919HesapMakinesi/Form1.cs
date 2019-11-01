using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180919HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(txtSayi1.Text);
            int sayi2 = Convert.ToInt16(txtSayi2.Text);
            int toplam = sayi1 + sayi2;
            //MessageBox.Show("Toplam:"+toplam);
            MessageBox.Show(string.Format("Toplam : {0}", toplam));
        }
    }
}
