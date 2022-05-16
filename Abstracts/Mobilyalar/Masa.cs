using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilyalar
{
    internal class Masa : Mobilya

    {
        public string Malzeme { get; set; }
        public int AyakSayisi { get; set; }
        public int CekmeceSayisi { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("Malzeme: " + Malzeme);
            Console.WriteLine("Ayak Sayısı: " + AyakSayisi);
            Console.WriteLine("Çekmece Sayısı: " + CekmeceSayisi);
        }
    }
}
