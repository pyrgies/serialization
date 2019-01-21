using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class Person
    {
        public enum Gender
        {
            Male,
            Female
        };

        private string Name;
        private string Birthdate;
        private Gender gender;

        public Person(string newName, string newBirthdate, Gender genderValue)
        {
            Name = newName;
            Birthdate = newBirthdate;
            gender = genderValue;
        }

        public override string ToString()
        {
            return " Person: " + Name + " Birthdate: " + Birthdate + " Gender: " + gender;
        }
    }
}

