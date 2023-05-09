using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Builder
{
    abstract class ArabaBuilder
    {
        protected Araba araba;
        public Araba Araba
        {
            get { return araba; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }
}
