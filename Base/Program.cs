using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////// Factory Method Design Pattern ///////////////////////////
            ///The main difference between a “factory method” and an “abstract factory” is that the factory method is a single method, and an abstract factory is an object. 
            ///The factory method is just a method, it can be overridden in a subclass, whereas the abstract factory is an object that has multiple factory methods on it.

            FactoryPattern.Creater carCreater = new();

            FactoryPattern.ICar bmw = carCreater.FactoryMethod(FactoryPattern.Cars.BMW);
            FactoryPattern.ICar togg = carCreater.FactoryMethod(FactoryPattern.Cars.TOGG);
            FactoryPattern.ICar tesla = carCreater.FactoryMethod(FactoryPattern.Cars.TESLA);

            bmw.GetName();
            togg.GetName();
            tesla.GetName();

            Console.Read();
        }
    }
}
