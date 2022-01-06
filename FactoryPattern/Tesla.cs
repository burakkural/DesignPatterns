using System;

namespace FactoryPattern
{
    public class Tesla : ICar
    {
        public void GetName()
        {
            Console.WriteLine("This car name is Tesla");
        }
    }
}
