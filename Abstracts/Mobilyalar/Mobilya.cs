using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilyalar
{
    internal abstract class Mobilya
    {
        public string Renk { get; set; }
        

        public abstract void OzellikleriYaz();
    }
}
