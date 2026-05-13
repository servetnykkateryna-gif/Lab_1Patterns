using System.Collections.Generic;
namespace Lab_1Patterns.Structural
{
    public interface IEnemy { void Scream(); }
    public class Ghoul : IEnemy
    {
        private string _id;
        public Ghoul(string id) => _id = id;
        public void Scream() => System.Console.WriteLine($"Composite: Ghoul {_id} screams!");
    }
    public class MonsterPack : IEnemy
    {
        private List<IEnemy> _monsters = new List<IEnemy>();
        public void Add(IEnemy m) => _monsters.Add(m);
        public void Scream()
        {
            System.Console.WriteLine("Composite: The pack is howling:");
            foreach (var monster in _monsters) monster.Scream();
        }
    }
}