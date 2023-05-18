using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSaga.Classes.Heroes;

namespace RPGSaga.Classes.Weapons{
    public abstract class Weapon{
        private string name;
        private int damage;

        private string ability;

        public Weapon(string name, int damage, string ability){
            this.name = name;
            this.damage = damage;
            this.ability = ability;
        }
    }
}