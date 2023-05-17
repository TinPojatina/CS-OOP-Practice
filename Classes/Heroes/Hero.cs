using RPGSaga.Classes.HeroGenerator;
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

        public Hero(
            string firstName,
            string lastName
            )
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }

        internal object GetFirstName()
        {
            return firstName;
        }
        internal object GetLastName()
        {
            return lastName;
        }

    }


}
