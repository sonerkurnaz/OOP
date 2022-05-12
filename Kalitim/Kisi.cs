using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Kisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        //Boş constructor
        public Kisi()
        {

        }
        //Parametreli constructor
        public Kisi(string ad, string soyad)
        {
            Adi = ad;
            Soyadi = soyad;
        }
        public Kisi(string ad, string soyad, string tcno)
        {
            Adi = ad;
            Soyadi = soyad;
            TcNo = tcno;
        }

    }

}
