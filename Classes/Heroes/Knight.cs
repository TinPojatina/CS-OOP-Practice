using System.Collections.Generic;
using RPGSaga.Classes.Weapons;

namespace RPGSaga.Classes.Heroes{
    class Knight : Hero
    {
        public Knight(string firstName, string lastName, int health, int armor, Weapon weapon, int mana) : base(firstName, lastName, health, armor, weapon, mana)
        {
        }
        
    }
}
