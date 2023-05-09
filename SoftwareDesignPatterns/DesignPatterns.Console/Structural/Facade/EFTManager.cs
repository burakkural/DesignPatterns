using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Facade
{
    public class EFTManager
    {
        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                System.Console.WriteLine("EFT " + toCustomer.CustomerNumber + " nolu hesaba gönderildi..");
            }
            else
                System.Console.WriteLine("Hesabınızda yeterli miktar olmadığı için EFT işleminiz gerçekleştirilemedi.");
        }
    }
}
