using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Bridge
{
    public class SamsungTV : ITV
    {
        public void Off()
        {
            System.Console.WriteLine("Samsung is turned off");
        }

        public void On()
        {
            System.Console.WriteLine("Samsung is turned on");
        }

        public void SwitchChannel(int channel)
        {
            System.Console.WriteLine("Samsung : channel - " + channel);
        }
    }
}
