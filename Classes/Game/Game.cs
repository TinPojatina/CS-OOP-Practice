using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSaga.Classes.Heroes;
using RPGSaga.Classes.HeroGenerator;

namespace RPGSaga.Classes.Game
{
    class Game
    {
        public Game(int number)
        {
            Run(number);
        }

        public void Run(int number)
        {
            Generator gen = new Generator();
            List<Hero> heroList = gen.GenerateHeroes(number);
            foreach (Hero hero in heroList)
            {
                Console.WriteLine(hero.getHero);
            }
        }
    }
}
