using System.Collections.Generic;
namespace Lab_1Patterns.Behavioral
{
    public class TrophyBag
    {
        private List<string> _trophies = new List<string> { "Голова Грифона", "Зуб Накера" };
        public IEnumerator<string> GetEnumerator() => _trophies.GetEnumerator();
    }
}