using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimTutarUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kadet;
            double toplam;
            kadet = Convert.ToInt16(textBox1.Text);

            if(kadet >= 0 && kadet <= 20)
            {
                toplam = (kadet * 8) - (((kadet * 8)*20) / 100);
                label3.Text = toplam + " TL";
            }
            if(kadet >=21 && kadet <= 40)
            {
                toplam = (kadet*8) - (((kadet*8)*40) / 100);
                label3.Text = toplam + " TL";
            }
            if(kadet >=41)
            {
                toplam = (kadet * 8) - (((kadet * 8) * 50) / 100);
                label3.Text = toplam + " TL";
            }
        }
    }
}
