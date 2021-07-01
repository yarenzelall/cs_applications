using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klavyedenGirilenİşlemiYapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            string islem;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            islem = Convert.ToString(textBox3.Text);
           
            switch(islem)
            {
                case "+": label4.Text = (sayi1 + sayi2).ToString(); break;
                case "-": label4.Text = (sayi1 - sayi2).ToString(); break;
                case "*": label4.Text = (sayi1 * sayi2).ToString(); break;
                case "/": label4.Text = (sayi1 / sayi2).ToString(); break;
                case "%": label4.Text = (sayi1 % sayi2).ToString(); break;
            }
        }
    }
}
