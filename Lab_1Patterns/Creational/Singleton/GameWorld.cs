using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Creational.Singleton
{
    public class GameWorld
    {
        private static GameWorld instance;

        private GameWorld()
        {
            Console.WriteLine("Game world created");
        }

        public static GameWorld GetInstance()
        {
            if (instance == null)
                instance = new GameWorld();

            return instance;
        }
    }
}
