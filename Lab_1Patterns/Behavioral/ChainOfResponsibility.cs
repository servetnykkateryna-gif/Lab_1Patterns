using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public abstract class WitcherHandler
    {
        protected WitcherHandler next;
        public void SetNext(WitcherHandler n) => next = n;
        public abstract void HandleContract(string difficulty);
    }
    public class Apprentice : WitcherHandler
    {
        public override void HandleContract(string diff)
        {
            if (diff == "easy") System.Console.WriteLine("Chain: Учень виконав легкий контракт.");
            else next?.HandleContract(diff);
        }
    }
}
