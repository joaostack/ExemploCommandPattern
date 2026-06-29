using NimRedV2.Interfaces;

namespace NimRedV2.Commands;

public class ArpScanCommand : ICommand
{
    public string Name => "arpscan";

    public void Execute(string[] args)
    {
        Console.WriteLine("Arp scan!");
    }
}