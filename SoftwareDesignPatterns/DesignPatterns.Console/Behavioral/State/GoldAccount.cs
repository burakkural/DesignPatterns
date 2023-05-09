using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.State
{
    public class GoldAccount : IAccountState
    {
        public void PayInterest()
        {
            System.Console.WriteLine("Interest paid with Golden Account");
        }

        public void WithdrawMoney()
        {
            System.Console.WriteLine("Money is taken with Golden Account");
        }
    }
}
