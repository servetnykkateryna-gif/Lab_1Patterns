using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Structural
{
    public interface ISign { string Cast(); }
    public class Igni : ISign { public string Cast() => "Igni (Fire)"; }
    public abstract class Witcher
    {
        protected ISign sign;
        protected Witcher(ISign s) => sign = s;
        public abstract void UseMagic();
    }
    public class WolfSchoolWitcher : Witcher
    {
        public WolfSchoolWitcher(ISign s) : base(s) { }
        public override void UseMagic() => System.Console.WriteLine($"Bridge: Wolf School Witcher casts {sign.Cast()}.");
    }
}
