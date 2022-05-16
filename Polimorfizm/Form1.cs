using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.Marka = "Nokia";
            nokia.Model = "3310";
            nokia.Fiyat = 300;
            nokia.TelefonCal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Default motorola = new Default();
            motorola.Marka = "Motorola";
            motorola.Model = "L6";
            motorola.Fiyat = 100;
            motorola.TelefonCal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();
            iphone.Marka = "Iphone";
            iphone.Model = "8";
            iphone.Fiyat = 500;
            iphone.TelefonCal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.Marka = "Samsung";
            samsung.Model = "S8";
            samsung.Fiyat = 400;
            samsung.TelefonCal();
        }
    }
}
