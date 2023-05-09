using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Prototype
{
    public abstract class MemberPrototype
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public abstract MemberPrototype Clone();
    }
}
