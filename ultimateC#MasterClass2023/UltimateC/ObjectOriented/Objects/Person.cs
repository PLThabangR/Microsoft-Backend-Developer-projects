using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Objects
{
    public class Person
    {
        public Person(string name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
        }

        public string Name { get; set; }
        //Assign value only during object creating
        //After object is created is not possible to modify init
        public int YearOfBirth { get; init; }

    }
}
