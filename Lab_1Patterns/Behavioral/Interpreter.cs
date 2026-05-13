using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public class RuneInterpreter
    {
        public void Interpret(string context) =>
            System.Console.WriteLine($"Interpreter: Руна '{context}' розшифрована як 'Сила'.");
    }
}
