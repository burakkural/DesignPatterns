using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Creater
    {
        public ICar FactoryMethod(Cars car)
        {
            ICar objCar = car switch
            {
                Cars.TESLA => new Tesla(),
                Cars.BMW => new Bmw(),
                Cars.TOGG => new Togg(),
                _ => throw new NotSupportedException(),
            };

            return objCar;
        }
    }
    public enum Cars
    {
        UNDEFINED = 0,
        TESLA = 1,
        BMW = 2,
        TOGG = 3,
    }
}
