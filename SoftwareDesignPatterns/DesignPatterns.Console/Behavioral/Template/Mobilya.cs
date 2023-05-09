using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Template
{
    class Mobilya : Alisveris
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Taksit;
        }

        public override void Urun()
        {
            UrunAdi = "Mobilya";
        }
    }
}
