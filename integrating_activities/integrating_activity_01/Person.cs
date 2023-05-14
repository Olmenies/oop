using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrating_activity_01
{
    internal class Person
    {
        #region Attributes
        private string dni;
        private string name;
        private string surname;
        private List<Car> ownedCars;
        #endregion

        #region Properties
        public string Dni { get { return dni; } set { dni = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public List<Car> OwnedCars { get { return ownedCars; } private set { ownedCars = value; } }
        #endregion

        #region Constructors
        public Person(string dni, string name, string surname)
        {
            Dni = dni;
            Name = name;
            Surname = surname;
            OwnedCars = new List<Car>();
        }

        public Person (Person newPerson) : this(newPerson.Dni, newPerson.Name, newPerson.Surname) { }
        #endregion

        #region Destructors
        ~Person()
        {
            Console.WriteLine($"Person with DNI {Dni} was destroyed");
        }
        #endregion

        #region Methods
        public List<Car> getPersonCars(List<Car> businessCars) {
            List<Car> personCars = new List<Car>();
            return personCars;
        }
        #endregion

        #region Events
        #endregion
    }
}
