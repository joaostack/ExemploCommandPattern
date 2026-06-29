using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimRedV2.Commands;

namespace NimRedV2.Core
{
    public class RegisterCommands
    {
        public static Mediator Register()
        {
            var mediator = new Mediator();

            mediator.Register(new ArpScanCommand());
            mediator.Register(new IPScanCommand());
            mediator.Register(new HelpCommand());
            mediator.Register(new ExitCommand());

            return mediator;
        }
    }
}