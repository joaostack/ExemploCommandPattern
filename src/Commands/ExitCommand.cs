using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimRedV2.Interfaces;
using Spectre.Console;

namespace NimRedV2.Commands
{
    public class ExitCommand : ICommand
    {
        public string Name => "exit";

        public void Execute(string[] args)
        {
            Environment.Exit(0);
        }
    }
}