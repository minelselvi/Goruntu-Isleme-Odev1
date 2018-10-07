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
    public partial class Form3 : Form
    {
        Bitmap kaynak, islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntüler|*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            int dik = kaynak.Height;
            int en = kaynak.Width;
            islem = new Bitmap(en, dik);
            for (int y = 0; y < dik; y++)
            {
                for (int x = 0; x < en; x++)
                {
                    Color normalrenk = kaynak.GetPixel(x, y);
                    double yeniRenk = ((normalrenk.R * 0.2125) + (normalrenk.G * 0.7154) + (normalrenk.B * 0.072));
                    int olusanRenk = Convert.ToInt16(yeniRenk);
                    Color finalRenk = Color.FromArgb(olusanRenk, olusanRenk, olusanRenk);



                    islem.SetPixel(x, y, finalRenk);
                }
            }
            islemBox.Image = islem;
        }
    }
}
        
 


