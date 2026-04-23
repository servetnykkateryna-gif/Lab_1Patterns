using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Abstract_Factory
{
    class WitcherEquipmentFactory : IEquipmentFactory
    {
        public Sword CreateSword()
        {
            return new Sword();
        }

        public Armor CreateArmor()
        {
            return new Armor();
        }
    }
}
