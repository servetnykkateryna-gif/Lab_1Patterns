using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public class GameState
    {
        public string Level { get; set; }
        public void Save() => System.Console.WriteLine($"Memento: Стан '{Level}' збережено.");
    }
}
