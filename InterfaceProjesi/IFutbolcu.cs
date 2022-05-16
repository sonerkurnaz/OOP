using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjesi
{
    internal interface IFutbolcu
    {
        public string AdSoyad { get; set; }
        public string FormaNumarasi { get; set; }
        public int SutGucu { get; set; }
        public int Refleks { get; set; }
        public bool HangiAyak { get; set; }
        public int Agresiflik { get; set; }
        public bool MilliMi { get; set; }
        public void CalimAt();
        public void PresYap();
        public void SutCek();
    }
}
