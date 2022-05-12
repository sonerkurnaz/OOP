using System;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kişi sınıfından bir örnek alalım

            Kisi ali = new Kisi();
            Personel ayse = new Personel();
            Console.WriteLine("Personel Maas:" + ayse.Maas);
            SatisMuduru veli = new SatisMuduru();

            Console.WriteLine("Satış Müdürü: " + veli.Maas);

        }
    }
}
