using System;
using System.Collections.Generic;
using RPGSaga.Classes.Heroes;
using RPGSaga.Classes.Weapons;

namespace RPGSaga.Classes.HeroGenerator
{
    class Generator
    {
        private Random random = new Random();

        public List<Hero> HeroList(int heroCount)
        {
            List<Hero> list = GenerateHeroes(heroCount);
            return list;
        }

        public List<Hero> GenerateHeroes(int numHeroes)
        {
            var heroList = new List<Hero>();

            for (int i = 0; i < numHeroes; i++)
            {
                Hero hero = new Hero(newFirstName(), newLastName(), numGenerator(3,4), numGenerator(3,4), weaponGenerator(), numGenerator(3,4));
                heroList.Add(hero);
            }
            return heroList;
        }

        public string newFirstName()
        {
            string[] firstNames = { "John", "Emily", "Michael", "Sophia", "David", "Olivia", "Daniel", "Emma", "Matthew", "Isabella" };
            int index = random.Next(firstNames.Length);
            return firstNames[index];
        }

        public string newLastName()
        {
            string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };
            int index = random.Next(lastNames.Length);
            return lastNames[index];
        }

        public int numGenerator(int min, int max)
        {
            int num = random.Next(min, max);
            return num;
        }

        public Weapon weaponGenerator()
        {
            string[] names = { "Spear", "Sword" };
            int randomIndex = random.Next(names.Length);

            switch (randomIndex)
            {
                case 0:
                    Weapon spear = new Spear(names[randomIndex], numGenerator(4,5), "Pierce");
                    return spear;
                case 1:
                    Weapon sword = new Sword(names[randomIndex], numGenerator(4,5), "Slash");
                    return sword;
                default:
                    return null;
            }
        }
    }
}
