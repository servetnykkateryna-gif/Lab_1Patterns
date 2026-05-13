using System.Collections.Generic;
namespace Lab_1Patterns.Structural
{
    public class CoinType
    {
        private string _name;
        public CoinType(string name) => _name = name;
        public void Display(int serial) => System.Console.WriteLine($"Flyweight: Orens Coin #{serial} displayed.");
    }
    public class CoinFactory
    {
        private static Dictionary<string, CoinType> _cache = new Dictionary<string, CoinType>();
        public static CoinType GetCoinType(string name)
        {
            if (!_cache.ContainsKey(name)) _cache[name] = new CoinType(name);
            return _cache[name];
        }
    }
}