using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Builder
{
     class ArabaUret
    {
        public void Uret(ArabaBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetMarka();
            Araba.SetModel();
            Araba.SetVites();

        }
    }
}
