using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public interface ICombatStrategy { void Strike(); }
    public class StrongStrike : ICombatStrategy
    {
        public void Strike() => System.Console.WriteLine("Strategy: Завдано потужного удару.");
    }
}
