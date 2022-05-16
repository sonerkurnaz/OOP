using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilyalar
{
    internal class Kanepe : Mobilya
    {
        public string KumasTuru { get; set; }
        public bool Bazalimi { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("Kanepenin Ozellikleri");
            Console.WriteLine("Kumas Turu:" + KumasTuru);
            Console.WriteLine("Bazalimi :" + Bazalimi);
        }
    }
}
