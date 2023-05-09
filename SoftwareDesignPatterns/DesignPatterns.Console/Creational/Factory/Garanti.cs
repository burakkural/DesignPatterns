using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Factory
{
    public class Garanti : Bank
    {
        public override string GetName()
        {
            return "Garanti Bankası";
        }
    }
}
