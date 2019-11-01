using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250919ListeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != "")
            {
                lstKisiler.Items.Add(txtIsim.Text.Trim().ToUpper());
                txtIsim.Clear();
                txtIsim.Focus();
            }

        }

        private void btnKisiSayisi_Click(object sender, EventArgs e)
        {
            int adet = lstKisiler.Items.Count;
            MessageBox.Show("Kişi Sayısı :"+adet.ToString());
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtIsimAra.Text!=string.Empty)
            {
                string isim = txtIsimAra.Text.ToUpper();
                if (lstKisiler.Items.Contains(isim))
                {
                    MessageBox.Show("Aranan isim listede mevcut.");
                }
                else
                {
                    MessageBox.Show("Aranan isim listede yok.");
                }
            }
        }
    }
}
