using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.State
{
    public class Account
    {

        IAccountState _accountState;
        public Account()
        {
            _accountState = new NormalAccount();
        }

        public void PayInterest()
        {
            _accountState.PayInterest();
        }

        public void WithdrawMoney()
        {
            _accountState.WithdrawMoney();
        }

        public void ChangeStatus(IAccountState newAccountState)
        {
            _accountState = newAccountState;
        }
    }
}
