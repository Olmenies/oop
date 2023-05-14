using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrating_activity_01
{
    internal class BusinessManager
    {
        #region Attributes
        private List<Car> cars;
        private List<Person> persons;
        #endregion

        #region Properties
        public List<Car> Cars { get { return cars; } private set { cars = value; } }
        public List<Person> People { get { return persons; } private set { persons = value; } }
        #endregion

        #region Constructors
        public BusinessManager()
        {
            Cars = new List<Car>();
            People = new List<Person>();
        }
        #endregion

        #region Destructors
        ~BusinessManager()
        {
            Console.WriteLine("BusinessManager was destroyed");
        }
        #endregion

        #region Methods
        public string AddCar(Car newCar)
        {
            Cars.Add(new Car(newCar));
            return "New car added";
        }
        public List<Car> GetCars() { return new List<Car>(Cars); }
        public string AddPerson(Person newPerson)
        {
            People.Add(new Person(newPerson));
            return "New person added";
        }
        public List<Person> GetPeople() { return new List<Person>(People); }
        public Person GetPersonByIndex(int index)
        {
            Person selectedPerson = People.ElementAt(index);
            return selectedPerson;
        }
        public Car GetCarByIndex(int index)
        {
            Car selectedCar = Cars.ElementAt(index);
            return selectedCar;
        }
        public Person GetPersonByDni(string dni)
        {
            Person selectedPerson = People.Find(el => el.Dni == dni);
            return selectedPerson;
        }
        public string DeletePerson(int index)
        {
            People.RemoveAt(index);
            return "Person was deleted";
        }
        public string DeleteCar(int index)
        {
            Cars.RemoveAt(index);
            return "Car was deleted";
        }
        public string BindOwnerCar(string ownerDni, string carPlate)
        {
            Car selectedCar = Cars.Find(el => el.Plate == carPlate);
            selectedCar.OwnerDni = ownerDni;

            Person selectedPerson = People.Find(el => el.Dni == ownerDni);
            selectedPerson.OwnedCars.Add(selectedCar);

            return "Car assigned";
        }
        public List<Car> GetOwnedCars(string ownerDni)
        {
            List<Car> ownedCars = new List<Car>();
            ownedCars = Cars.FindAll(el => el.OwnerDni == ownerDni);
            return ownedCars;
        }
        #endregion

        #region Events
        #endregion
    }
}
