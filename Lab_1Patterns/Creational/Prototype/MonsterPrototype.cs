using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Prototype
{
    class MonsterPrototype
    {
        public string Name;

        public MonsterPrototype Clone()
        {
            return (MonsterPrototype)this.MemberwiseClone();
        }
    }
}
