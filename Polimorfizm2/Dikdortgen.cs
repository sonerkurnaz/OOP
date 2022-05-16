using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    internal class Dikdortgen : Hesapla
    {
        public double UzunKenar { get; set; }
        public double KisaKenar { get; set; }
        public override double Alan()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
