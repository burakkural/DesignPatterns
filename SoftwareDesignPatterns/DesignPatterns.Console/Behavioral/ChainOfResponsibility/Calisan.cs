using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.ChainOfResponsibility
{
    public abstract class Calisan
    {
        protected Calisan SiradakiOnayci;

        public void SiradakiOnayciyiSetEt(Calisan siradakiOnayci)
        {
            this.SiradakiOnayci = siradakiOnayci;
        }

        public abstract void ProcessRequest(Withdraw req);
    }
}
