using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Facade
{
    public class BankingFacade
    {
        private EFTManager _eftManager;
        private CreditManager _creditManager;

        public BankingFacade()
        {
            _eftManager = new EFTManager();
            _creditManager = new CreditManager();
        }

        public void SendEFT(Customer fromCustomter, Customer toCustomter, decimal eftAmount)
        {
            _eftManager.SendEFT(fromCustomter, toCustomter, eftAmount); 
        }

        public void UseCredit(Customer customer)
        {
            _creditManager.UseCredit(customer);
        }
    }
}
