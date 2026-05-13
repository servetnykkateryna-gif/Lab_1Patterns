using System;
using Lab_1Patterns.Creational;
using Lab_1Patterns.Creational.Abstract_Factory;
using Lab_1Patterns.Creational.Builder;
using Lab_1Patterns.Creational.Factory;
using Lab_1Patterns.Creational.Singleton;
using Lab_1Patterns.Structural; // Додано для другої лаби

namespace Lab_1Patterns
{
    internal class Program
    {
        static void Main()
        {
            // --- Лабораторна 1: Породжуючі патерни ---
            Console.WriteLine("=== Witcher Creational Patterns ===");

            var world = GameWorld.GetInstance();
            var monster = MonsterFactory.CreateMonster("ghoul");
            monster.Attack();

            IEquipmentFactory factory = new WitcherEquipmentFactory();
            var sword = factory.CreateSword();
            sword.Use();

            CharacterBuilder builder = new CharacterBuilder();
            builder.BuildWeapon();
            var character = builder.GetCharacter();
            Console.WriteLine("Character created with " + character.Weapon);

            // --- Лабораторна 2: Структурні патерни ---
            Console.WriteLine("\n=== Witcher Structural Patterns ===");

            // 1. Adapter
            IPotion potion = new PotionAdapter(new OldAlchemicalMix());
            potion.Drink();

            // 2. Bridge
            Witcher geralt = new WolfSchoolWitcher(new Igni());
            geralt.UseMagic();

            // 3. Composite
            MonsterPack pack = new MonsterPack();
            pack.Add(new GhoulUnit("№1"));
            pack.Add(new GhoulUnit("№2"));
            pack.Scream();

            // 4. Decorator
            ISword oiledSword = new OilDecorator(new SilverSword());
            Console.WriteLine($"Decorator: {oiledSword.GetDescription()}");

            // 5. Facade
            HuntPreparation prep = new HuntPreparation();
            prep.PrepareForHunt();

            // 6. Flyweight
            var coinType = CoinFactory.GetCoinType("Oren");
            coinType.Display(777);

            // 7. Proxy
            INoticeBoard board = new NoticeBoardProxy();
            board.ViewContracts();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadLine();
        }
    }
}