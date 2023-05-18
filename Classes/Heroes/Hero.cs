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

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int CurrentHealth
        {
            get { return this.currentHealth; }
            set { this.currentHealth = value; }
        }
        public int Armor
        {
            get { return this.armor; }
            set { this.armor = value; }
        }

        public int CurrentArmor
        {
            get { return this.currentArmor; }
            set { this.currentArmor = value; }
        }
        public Weapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public int Mana
        {
            get { return this.mana; }
            set { this.mana = value; }
        }

        public int CurrentMana
        {
            get { return this.currentMana; }
            set { this.currentMana = value; }
        }
        public void resetMana()
        {
            this.currentMana = this.mana;
        }
        public void resetHealth()
        {
            this.currentHealth = this.health;
        }
        public void resetArmor()
        {
            this.currentArmor = this.armor;
        }
    }
}
