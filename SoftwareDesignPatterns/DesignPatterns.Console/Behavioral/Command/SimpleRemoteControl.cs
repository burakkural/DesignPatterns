using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Command
{
    public class SimpleRemoteControl
    {
        ICommand slot;
        public SimpleRemoteControl()
        {
        }

        public void setCommand(ICommand command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
