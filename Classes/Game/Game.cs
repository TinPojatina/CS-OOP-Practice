using System;
using System.Collections.Generic;
using System.Xml.Linq;
using RPGSaga.Classes.Heroes;
using RPGSaga.Classes.HeroGenerator;

namespace RPGSaga.Classes.Game
{
    class Game
    {
        public Game()
        {
            Console.Write("Please enter the desired number of heroes: ");
            string heroCount = Console.ReadLine();
            // Console.Write("Please enter the maximum number of peasants in the game: ");
            // string maxPeasants = Console.ReadLine();

            if (int.TryParse(heroCount, out int count) /*&& int.TryParse(maxPeasants, out int max)*/)
            {
                Run(count, 0);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public void Run(int max, int number)
        {
            Generator gen = new Generator();
            List<Hero> heroList = gen.GenerateHeroes(max);
            foreach (Hero hero in heroList)
            {
                string heroName = $"{hero.FirstName} {hero.LastName}";
                Console.WriteLine("Hero: " + heroName);
            }
        }
    }
}
