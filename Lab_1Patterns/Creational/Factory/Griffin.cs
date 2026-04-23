using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Factory
{
    class Griffin : IMonster
    {
        public void Attack()
        {
            Console.WriteLine("Griffin attacks!");
        }
    }
}
