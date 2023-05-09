using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Bridge
{
    public class LogitechRemoteControl : RemoteControl
    {
        public LogitechRemoteControl(ITV tv) : base(tv)
        {

        }

        public void SetChannelKeyboard(int channel)
        {
            SetChannel(channel);
            System.Console.WriteLine("Logitech use keyword to set channel.");
        }
    }
}
