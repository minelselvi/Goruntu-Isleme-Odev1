using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace minel_selvi
{
    public partial class Form2 : Form
    {
        Bitmap kaynak, islem;
        public Form2()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);

            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dik = kaynak.Height;
            int en = kaynak.Width;
            islem = new Bitmap(en,dik);
            for (int y = 0; y < dik; y++) 
            {
                for(int x=0; x<en; x++)
                {
                    Color normalrenk = kaynak.GetPixel(x, y);
                   int yeni =(normalrenk.R + normalrenk.G+ normalrenk.B) / 3;
                    Color yeniRenk = Color.FromArgb(yeni,yeni,yeni);
                    islem.SetPixel(x, y, yeniRenk);

                }
            }
            islemBox.Image = islem;

        }

        private void kaynakBox_Click(object sender, EventArgs e)
        {

        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntüler|*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

            }
        }
    }
}
