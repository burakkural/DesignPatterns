using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Facade
{
    public static class ControlManager
    {
        public static bool CheckHasEnoughCashInBankAccount(Customer customer, decimal amount)
        {
            if (customer.CashAmount >= amount)
                return true;
            else
                return false;
        }

        public static bool CheckCanUseCredit(string IDNo)
        {
            //test için her zaman return true
            return true;
        }
    }
}
