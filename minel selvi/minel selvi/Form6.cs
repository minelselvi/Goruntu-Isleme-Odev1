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
    public partial class Form6 : Form
    {
        Bitmap kaynak, islem;
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //yesil yapan 
            int dik = kaynak.Height;
            int en = kaynak.Width;
            islem = new Bitmap(en, dik);
            for (int y = 0; y < dik; y++)
            {
                for (int x = 0; x < en; x++)
                {
                    Color normal = kaynak.GetPixel(x, y);
                    Color finish = Color.FromArgb(normal.R, 0, normal.B);
                    islem.SetPixel(x, y, finish);
                }
            }
            islemBox.Image = islem;
                }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //kırmızı yapan
            int dik = kaynak.Height;
            int en = kaynak.Width;
            islem = new Bitmap(en, dik);
            for (int y = 0; y < dik; y++)
            {
                for (int x = 0; x < en; x++)
                {
                    Color normal = kaynak.GetPixel(x, y);
                    Color finish = Color.FromArgb(0, normal.G, normal.B);
                    islem.SetPixel(x, y, finish);
                }
            }
            islemBox.Image = islem;

                }

        private void button3_Click(object sender, EventArgs e)
        {
            //mavi yapan
            int dik = kaynak.Height;
            int en = kaynak.Width;
            islem = new Bitmap(en, dik);
            for (int y = 0; y < dik; y++)
            {
                for (int x = 0; x < en; x++)
                {
                    Color normal = kaynak.GetPixel(x, y);
                    Color finish = Color.FromArgb(normal.R, normal.G, 0);
                    islem.SetPixel(x, y, finish);
                }
            }
            islemBox.Image = islem;

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
    }
}
