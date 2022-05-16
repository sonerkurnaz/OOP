using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class Nokia : BasePhone
    {
        public override void TelefonCal()
        {
            using (SoundPlayer player = new SoundPlayer("nokia.wav"))
            {
                player.Play();
            }
        }
    }
}
