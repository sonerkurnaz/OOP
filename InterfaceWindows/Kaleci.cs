using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWindows
{
    internal class Kaleci : IFutbolcu
    {
        public string AdSoyad { get; set; }
        public string FormaNumarasi { get; set; }
        public int SutGucu { get; set; }
        public int Refleks { get; set; }
        public bool HangiAyak { get; set; }
        public int Agresiflik { get; set; }
        public bool MilliMi { get; set; }
        public bool ElleTopKontrol { get; set; }
        public void PenaltiKurtar()
        {

        }
        public void CekilenSutlariKurtar()
        {

        }


        public void CalimAt()
        {
            throw new NotImplementedException();
        }

        public void PresYap()
        {
            throw new NotImplementedException();
        }

        public void SutCek()
        {
            throw new NotImplementedException();
        }
    }
}
