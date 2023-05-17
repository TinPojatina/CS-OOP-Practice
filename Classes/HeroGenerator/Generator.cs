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
                Hero hero = new Hero(newFirstName(),newLastName());
                heroList.Add(hero);
            }
                return heroList;
        }

        public string newFirstName(){
            Console.WriteLine("What is your name?");
            string[] firstNames = { "John", "Emily", "Michael", "Sophia", "David", "Olivia", "Daniel", "Emma", "Matthew", "Isabella" };
            Random random = new Random();
            int index = random.Next(firstNames.Length);
            return firstNames[index];
        }

        public string newLastName(){
            Console.WriteLine("What is your name?");
            string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };
            Random random = new Random();
            int index = random.Next(lastNames.Length);
            return lastNames[index];
        }
    }
}
