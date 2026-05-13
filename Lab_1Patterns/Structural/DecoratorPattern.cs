using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Structural
{
    public interface ISword { string GetDescription(); }
    public class SteelSword : ISword { public string GetDescription() => "Steel Sword"; }
    public class OilDecorator : ISword
    {
        private ISword _sword;
        public OilDecorator(ISword s) => _sword = s;
        public string GetDescription() => _sword.GetDescription() + " with Necrophage Oil";
    }
}
