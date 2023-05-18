using RPGSaga.Classes.HeroGenerator;
using RPGSaga.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSaga.Classes.Heroes
{
    public class Hero
    {
        private string firstName;
        private string lastName;
        private int health;
        private int currentHealth;
        private int armor;
        private int currentArmor;
        private Weapon weapon;
        private int mana;
        private int currentMana;  
        public Hero(
            string firstName,
            string lastName,
            int health,
            int armor,
            Weapon weapon,
            int mana
            )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.health = health;
            this.currentHealth = health;
            this.armor = armor;
            this.currentArmor = armor;
            this.weapon = weapon;
            this.mana = mana;
            this.currentMana = mana;
        }

        //public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }

        public object GetFirstName()
        {
            return firstName;
        }
        public object GetLastName()
        {
            return lastName;
        }

    }


}
