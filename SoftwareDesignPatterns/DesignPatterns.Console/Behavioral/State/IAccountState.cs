using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.State
{
    public interface IAccountState
    {
        void WithdrawMoney();
        void PayInterest();
    }
}
