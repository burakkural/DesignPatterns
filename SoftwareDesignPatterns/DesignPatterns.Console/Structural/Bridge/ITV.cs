using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Bridge
{
    public interface ITV
    {
        public void On();
        public void Off();
        public void SwitchChannel(int channel);
    }
}
