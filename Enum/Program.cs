using System;

namespace EnumKonusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.AdiSoyadi = "Rıdvan Aksoy";
            p.Departman = Departmanlar.GrafikTasarim;

            int seciliEnumIndexi = (int)Enum.Parse(typeof(Departmanlar), "GrafikTasarim");

            Departmanlar cikacak;
            bool sonuc = Enum.TryParse<Departmanlar>("GrafikTasarim", out cikacak);

            if (sonuc)
            {
                Console.WriteLine("Personelin Departmanı => " + cikacak.ToString());
            }
            else
            {
                Console.WriteLine("Uygun departman seçildiğinden emin olunuz!");
            }

            switch (p.Departman)
            {
                case Departmanlar.Yazilim:
                    Console.WriteLine("Hoşgeldin, bilgisayarın tanrısı!");
                    break;
                case Departmanlar.SistemAgUzmanligi:
                    break;
                case Departmanlar.GrafikTasarim:
                    break;
                case Departmanlar.Ingilizce:
                    break;
                case Departmanlar.Muhasebe:
                    break;
                default:
                    break;
            }


            Console.WriteLine("Departman Listesi");
            foreach (var item in Enum.GetNames(typeof(Departmanlar)))
            {
                Console.WriteLine(item + " - " + Convert.ToInt32(Enum.Parse(typeof(Departmanlar), item)));
            }
    }
}
