using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class SatisElemani : Personel
    {
        //Sadece miras verdiği classlardan ulasılabilir.
        //dısarıya acık degildir.
        protected bool ArabasiVarMi { get; set; }
        public void ToplantiYap()
        {

        }
        public void MusteriZiyareti()
        {

        }
        public void SatisYap()
        {

        }
        public SatisElemani()
        {
            Maas = Maas + 2000;
        }
    }
}
