using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Togg : ICar
    {
        public void GetName()
        {
            Console.WriteLine("This car name is TOGG");
        }
    }
}
