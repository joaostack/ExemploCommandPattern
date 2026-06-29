using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimRedV2.Interfaces;
using Spectre.Console;

namespace NimRedV2.Commands
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";

        public void Execute(string[] args)
        {
            AnsiConsole.MarkupLine(@"
Menu de Ajuda:
[bold white]arpscan:[/] [bold italic white]realiza um scan do tipo ARP[/]
[bold white]ipscan:[/] [bold italic white]realiza um scan do tipo IP[/]
[bold white]exit:[/] [bold italic white]Sair do programa[/]
");
        }
    }
}