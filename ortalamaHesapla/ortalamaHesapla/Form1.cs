using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalamaHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ort;
            string durum;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);

            ort = ((vize + final) / 2);

            if(ort>=50)
            {
                durum = " GEÇTİ";
            }
            else
            {
                durum = " KALDI";
            }

            textBox3.Text = ort.ToString("0.00") + " / " + durum;
        }
    }
}
