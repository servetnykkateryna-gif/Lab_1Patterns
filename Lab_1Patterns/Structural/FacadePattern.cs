using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Structural
{
    public class Alchemy { public void Prepare() => System.Console.WriteLine("Facade: Potions prepared."); }
    public class Blacksmith { public void Sharpen() => System.Console.WriteLine("Facade: Sword sharpened."); }
    public class HuntPreparation
    {
        private Alchemy _alchemy = new Alchemy();
        private Blacksmith _smith = new Blacksmith();
        public void PrepareForHunt()
        {
            _alchemy.Prepare();
            _smith.Sharpen();
            System.Console.WriteLine("Facade: Geralt is ready for the contract.");
        }
    }
}
