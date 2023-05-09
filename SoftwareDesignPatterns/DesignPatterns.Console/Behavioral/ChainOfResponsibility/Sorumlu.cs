using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.ChainOfResponsibility
{
    public class Sorumlu : Calisan
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 40000)
            {
                System.Console.WriteLine("{0} tarafından para çekme işlemi onaylandı #{1}", this.GetType().Name, req.Amount);
            }
            else if (SiradakiOnayci != null)
            {
                System.Console.WriteLine("{0} TL işlem tutarı {1} max. limitini aştığından işlem yöneticiye gönderildi.", req.Amount, this.GetType().Name);

                SiradakiOnayci.ProcessRequest(req);
            }
        }
    }
}
