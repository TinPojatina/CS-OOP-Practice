using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSaga.Classes.Heroes;

namespace RPGSaga.Classes.Weapons{
    public class Spear: Weapon{
        public Spear(string name, int damage, string ability) : base("Spear", damage, "Pierce"){}

    }
}