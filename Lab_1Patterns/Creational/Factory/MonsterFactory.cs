using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Factory
{
    class MonsterFactory
    {
        public static IMonster CreateMonster(string type)
        {
            if (type == "ghoul")
                return new Ghoul();
            else
                return new Griffin();
        }
    }
}
