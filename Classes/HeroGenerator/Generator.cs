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

        public List<Hero> GenerateHeroes(int number)
        {
            var heroList = new List<Hero>();
            
            for(int i = 0; i < number; i++)
            {
                Hero hero = new Hero("HELP ME");
                heroList.Add(hero);
            }
                return heroList;
        }
    }
}
