using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Builder
{
     class KiaBuilder : ArabaBuilder
    {
        public KiaBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM()
        {
            araba.KM = 190000;
        }

        public override void SetMarka()
        {
            araba.Marka = "Kia";
        }

        public override void SetModel()
        {
            araba.Model = "Rio";
        }

        public override void SetVites()
        {
            araba.OtomatikVitesMi = false;
        }
    }
}
