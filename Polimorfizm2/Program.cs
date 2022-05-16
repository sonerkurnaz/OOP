using System;

namespace Polimorfizm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cember cember = new Cember();
            cember.Yaricap = 3;
            Console.WriteLine("Çember Alanı: " + cember.Alan());

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 5;
            Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen.Alan());

            Console.WriteLine("Hello World!");
        }
    }
}
