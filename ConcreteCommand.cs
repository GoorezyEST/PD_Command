using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_PD
{
    // The 'ConcreteCommand' class
    internal class ConcreteCommand : Command
    {
        private Receiver _receiver;

        // Constructor
        public ConcreteCommand(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public override void Execute()
        {
            Console.WriteLine("ConcreteCommand: Calling Receiver.Action()");
            _receiver.Action();
        }
    }
}
