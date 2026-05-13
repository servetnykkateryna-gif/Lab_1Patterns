using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public interface ICommand { void Execute(); }
    public class CastSignCommand : ICommand
    {
        private string _sign;
        public CastSignCommand(string sign) => _sign = sign;
        public void Execute() => System.Console.WriteLine($"Command: Використано знак {_sign}.");
    }
}
