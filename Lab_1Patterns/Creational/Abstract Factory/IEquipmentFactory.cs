using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Abstract_Factory
{
    interface IEquipmentFactory
    {
        Sword CreateSword();
        Armor CreateArmor();
    }
}
