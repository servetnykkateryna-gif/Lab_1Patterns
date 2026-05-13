using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public interface IWitcherState { void Action(); }
    public class MeditationState : IWitcherState
    {
        public void Action() => System.Console.WriteLine("State: Геральт медитує та відновлює сили.");
    }
}
