using NimRedV2.Commands;
using Spectre.Console;

namespace NimRedV2.Core
{
    public class Menu
    {
        public static void Start()
        {
            while (true)
            {
                AnsiConsole.Write(new FigletText("NimRedV2").Color(Color.Aqua));
                AnsiConsole.MarkupLine("[bold]Digite 'help' para listar os comandos disponíveis.[/]");

                var mediator = RegisterCommands.Register();

                while (true)
                {
                    var cmd = AnsiConsole.Ask<string>("[bold white]>[/] ");
                    mediator.Execute(cmd);
                }
            }
        }
    }
}