using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Bridge
{
    public abstract class RemoteControl
    {
        private  ITV tv;

        public RemoteControl(ITV tv)
        {
            this.tv = tv;
        }

        public void TurnOn()
        {
            tv.On();
        }

        public void TurnOff()
        {
            tv.Off();
        }

        public void SetChannel(int  channel)
        {
            tv.SwitchChannel(channel);
        }
    }
}
