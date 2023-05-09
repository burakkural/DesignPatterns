using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Template
{
     class Televizyon : Alisveris
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Pesin;
        }

        public override void Urun()
        {
            UrunAdi = "Televizyon";
        }
    }
}
