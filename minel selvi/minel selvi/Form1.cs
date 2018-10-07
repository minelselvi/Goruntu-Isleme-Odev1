using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minel_selvi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ortalamadegerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ortalamadeger= new Form2 ();
            ortalamadeger.ShowDialog();
        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bt709 = new Form3();
            bt709.ShowDialog();
        }

        private void griyontemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 luma = new Form4();
            luma.ShowDialog();
        }

        private void acıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 acıklık = new Form5();
            acıklık.ShowDialog();
        }

        private void kanalacmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 kanalacma = new Form6() ;
            kanalacma.ShowDialog();
        }
    }
}
