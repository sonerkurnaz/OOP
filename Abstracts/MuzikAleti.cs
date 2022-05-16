using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    //Abstract classlar sadece base class olarak tanımlanmıstır. o yüzden sadece kalıtım verir.
    //Abstract classlardan instance alınamaz. yani new'lenemez.
    public abstract class MuzikAleti
    {
        public string Marka { get; set; }
        public string Aciklama { get; set; }

        //Soyut metoddur. Miras verdiği yerde mutlaka tanımlanmalıdır.
        //yani gövdesi yazılmalıdır.
        //Govde : Metodun icersisindeki kodlar.

        //Abstract olarak isaretlenmis tüm yapilar override edilmek zorundadır
        public abstract string Cal();
    }
}
