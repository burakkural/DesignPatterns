using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Prototype
{
    public class Member : MemberPrototype
    {
        public override MemberPrototype Clone()
        {
            return this.MemberwiseClone() as MemberPrototype;
        }
    }
}
