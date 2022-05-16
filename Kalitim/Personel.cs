using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Personel : Kisi,IPersonel1
    {
        public int Maas { get; set; }
        public string Departman { get; set; }
        public Personel()
        {
            Maas = 4500;
        }

        public bool IseZamanındaGel()
        {
            throw new NotImplementedException();
        }
    }
}
