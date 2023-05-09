using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Singleton
{
    public class SingletonObject
    {
        private static SingletonObject instance;
        protected SingletonObject()
        {
            
        }
        public static SingletonObject getInstance()
        {
            if (instance == null) 
            { 
                instance = new SingletonObject();
            }

            return instance;
        }
    }
}
