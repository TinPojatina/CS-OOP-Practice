using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSaga.Classes.Heroes
{
    public class Hero
    {
        private string name;

        public Hero(string name)
        {
            this.name = name;
        }
        public string getHero()
        {
            return this.name;
        }
    }
}
