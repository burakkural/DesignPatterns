using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Bridge
{
    public class SonyTV : ITV
    {
        public void Off()
        {
            System.Console.WriteLine("Sony is turned off");
        }

        public void On()
        {
            System.Console.WriteLine("Sony is turned on");
        }

        public void SwitchChannel(int channel)
        {
            System.Console.WriteLine("Sony : channel - " + channel);
        }
    }
}
