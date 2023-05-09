using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Factory
{
    public class Ziraat : Bank
    {
        public override string GetName()
        {
            return "Ziraat Bankası";
        }
    }
}
