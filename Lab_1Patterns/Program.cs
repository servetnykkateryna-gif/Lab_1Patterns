using System;
using Lab_1Patterns.Creational;
using Lab_1Patterns.Creational.Abstract_Factory;
using Lab_1Patterns.Creational.Builder;
using Lab_1Patterns.Creational.Factory;
using Lab_1Patterns.Creational.Singleton;

namespace Lab_1Patterns
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Witcher Creational Patterns ===");

            var world = GameWorld.GetInstance();

            var monster = MonsterFactory.CreateMonster("ghoul");
            monster.Attack();

            IEquipmentFactory factory = new WitcherEquipmentFactory();
            var sword = factory.CreateSword();
            sword.Use();
            var armor = factory.CreateArmor();
            armor.Wear();

            CharacterBuilder builder = new CharacterBuilder();
            builder.BuildWeapon();
            builder.BuildArmor();
            var character = builder.GetCharacter();

            Console.WriteLine("Character created with " + character.Weapon);

            Console.ReadLine();
        }
    }
}