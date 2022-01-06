using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bmw : ICar
    {
        public void GetName()
        {
            Console.WriteLine("This car name is BMW");
        }
    }
}
