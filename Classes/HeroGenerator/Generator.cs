using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSaga.Classes.Heroes;

namespace RPGSaga.Classes.HeroGenerator
{
    class Generator
    {
        public Generator() { }

        public List<Hero> HeroList(int peasantCount, int heroCount)
        {
            var heroGen = new Generator();
            List<Hero> list = heroGen.GenerateHeroes(peasantCount, heroCount);
            return list;
        }

        public List<Hero> GenerateHeroes(int numPeasants, int numHeroes)
        {
            var heroList = new List<Hero>();
            
            for(int i = 0; i < numHeroes; i++)
            {
                Hero hero = new Hero("Help", "Me");
                heroList.Add(hero);
            }
                return heroList;
        }
    }
}
