using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Builder
{
    class CharacterBuilder
    {
        private WitcherCharacter character = new WitcherCharacter();

        public void BuildWeapon()
        {
            character.Weapon = "Silver Sword";
        }

        public void BuildArmor()
        {
            character.Armor = "Kaer Morhen Armor";
        }

        public WitcherCharacter GetCharacter()
        {
            return character;
        }
    }
}
