using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Command
{
    public class Light
    {
        public Light()
        {
        }

        public void On()
        {
            System.Console.WriteLine("Light is on");
        }

        public void Off()
        {
            System.Console.WriteLine("Light is off");
        }
    }
}
