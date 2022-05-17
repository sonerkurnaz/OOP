using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IFutbolcu kaleci = new Kaleci();


            Kaleci tafarel = new Kaleci();
            tafarel.AdSoyad = "Tafarel";
            tafarel.SutGucu = 70;
            tafarel.FormaNumarasi = "1";
            tafarel.Agresiflik = 65;
            tafarel.MilliMi = true;
            tafarel.Refleks = 75;

            listBox1.Items.Add(tafarel);

            IFutbolcu defans = new Defans();

            Defans takozRecep = new Defans();
            takozRecep.Refleks = 90;
            takozRecep.Agresiflik = 80;
            takozRecep.SutGucu = 90;
            takozRecep.AdSoyad = " Takoz Recep";
            takozRecep.HangiAyak = true;
            takozRecep.MilliMi = true;
            takozRecep.FormaNumarasi = "5";
            listBox1.Items.Add(takozRecep);

            Forvet cenkTosun = new Forvet();
            cenkTosun.SutGucu = 80;
            cenkTosun.Agresiflik = 80;
            cenkTosun.MilliMi = true;
            cenkTosun.FormaNumarasi = "11";
            cenkTosun.Refleks = 70;
            //listBox1.Items.Add(cenkTosun);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            if (listBox1.SelectedItem != null)
            {
                IFutbolcu secilenFutbolcu = (IFutbolcu)listBox1.SelectedItem;

                foreach (var item in secilenFutbolcu.GetType().GetProperties())
                {
                    Label label = new Label();
                    label.Name = item.Name;
                    label.Text = item.Name + " " + item.GetValue(secilenFutbolcu).ToString();
                    flowLayoutPanel1.Controls.Add(label);
                }
            }
        }
    }
}
         
   
