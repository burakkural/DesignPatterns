using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Factory
{
    public class BankCreator
    {
        public Bank BankFactory(BankEnum bankEnum)
        {
            Bank bank = null;

            switch (bankEnum) 
            {
                case BankEnum.Garanti:
                    bank = new Garanti();
                    break;

                case BankEnum.Ziraat:
                    bank = new Ziraat();    
                    break;
            }

            return bank;
        }
    }

    public enum BankEnum
    {
        Garanti,
        Ziraat
    }
}
