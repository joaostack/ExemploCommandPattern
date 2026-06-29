using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimRedV2.Interfaces;

namespace NimRedV2.Commands
{
    public class IPScanCommand : ICommand
    {
        public string Name => "ipscan";

        public void Execute(string[] args)
        {
            Console.WriteLine("IP Scan!");
        }
    }
}