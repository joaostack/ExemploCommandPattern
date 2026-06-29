using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimRedV2.Interfaces;
using Spectre.Console;

namespace NimRedV2.Commands
{
    public class Mediator
    {
        private Dictionary<string, ICommand> _commands = new();

        public void Register(ICommand command)
        {
            _commands[command.Name] = command;
        }

        public void Execute(string input)
        {
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0)
                return;

            var commandName = parts[0];
            var args = parts.Skip(1).ToArray();

            if (_commands.TryGetValue(commandName, out var command))
            {
                command.Execute(args);
            }
            else
            {
                AnsiConsole.MarkupLine("[bold red]Comando não encontrado.[/]");
            }
        }
    }
}