using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    internal class Cember : Hesapla
    {
        public int Yaricap { get; set; }
        public double Cevre()
        {
            return 2 * Yaricap * Math.PI;
        }
        public override double Alan()
        {
            return Math.PI * Math.Pow(Yaricap, 2);
        }
    }
}
