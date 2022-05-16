using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal interface IMuhasebe
    {
        public void KdvHesapla();
        public void MaasOde();
        public void VergiOde();
    }
}
