using Lab_1Patterns.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Factory_Method
{
    class MonsterCreator : Creator
    {
        public override IMonster CreateMonster()
        {
            return new Ghoul();
        }
    }
}
