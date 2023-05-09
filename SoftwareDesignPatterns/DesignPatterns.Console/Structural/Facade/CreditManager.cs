using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Facade
{
    public class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.CheckCanUseCredit(customer.IDNo))
                System.Console.WriteLine("Kredi kullandırılmıştır.");
            else
                System.Console.WriteLine("Banka kredinizi onaylamamıştır.");
        }
    }
}
