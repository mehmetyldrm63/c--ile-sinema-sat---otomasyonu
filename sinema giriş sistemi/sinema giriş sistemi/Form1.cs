using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_giriş_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int kasa = 0;//kasa local alanda olmalidir button birin içinde olsaydi sürekil kasa 0 lanirdi
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, sut, bilet;
           
            int toplam = 0;
            misir = Convert.ToInt32(textBox1.Text);
            sut = Convert.ToInt32(textBox2.Text);
            cay = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);
            toplam = misir * 10 + sut * 5 + cay * 15 + bilet * 20;
            label7.Text =  toplam +" "+"TL";
            kasa = kasa + toplam;
            label9.Text = kasa + " " + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label7.Text = "00 TL";
           
        }
    }
}
