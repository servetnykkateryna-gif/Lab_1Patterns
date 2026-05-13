using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Structural
{
    public interface IPotion { void Drink(); }
    public class OldAlchemicalMix { public void Consume() => System.Console.WriteLine("Adapter: Drank an ancient alchemical mix."); }
    public class PotionAdapter : IPotion
    {
        private OldAlchemicalMix _oldMix;
        public PotionAdapter(OldAlchemicalMix mix) => _oldMix = mix;
        public void Drink() => _oldMix.Consume();
    }
}
