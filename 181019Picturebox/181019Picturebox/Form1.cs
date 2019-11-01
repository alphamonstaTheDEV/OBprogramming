using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181019Picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();

            //DialogResult sonuc = ofd.ShowDialog();

            //if (sonuc== DialogResult.OK)
            //{
            //    pictureBox1.ImageLocation = ofd.FileName;
            //}
            //pictureBox1.Image = Properties.Resources.ataturk;
            pictureBox1.ImageLocation = "ataturk.jpg";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
