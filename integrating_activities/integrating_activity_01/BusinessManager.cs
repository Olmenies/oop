using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Car GetCarByPlate(string plate)
        {
            Car selectedCar = Cars.Find(el => el.Plate == plate);
            return selectedCar;
        }
        public string DeletePerson(int index)
        {
            try
            {
                Person selectedPerson = People.ElementAt(index);
                if (selectedPerson.OwnedCars.Count > 0)
                {
                    throw new Exception("You can not delete a person with cars");
                }
                else
                {
                    People.RemoveAt(index);
                    return "Person was deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Person was not deleted";
            }
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
        public string UpdatePerson(int index, Person person)
        {
            Person newPerson = new Person(person);
            newPerson.OwnedCars = People[index].OwnedCars;

            Cars.ForEach(el =>
            {
                if (el.OwnerDni == People[index].Dni)
                {
                    el.OwnerDni = newPerson.Dni;
                }
            });

            People[index] = newPerson;

            return "Person updated";
        }
        public string UpdateCar(int index, Car car)
        {
            Car newCar = new Car(car);

            if (Cars[index].OwnerDni != "")
            {
                newCar.OwnerDni = Cars[index].OwnerDni;

                Person selectedPerson = People.Find(el => el.Dni == newCar.OwnerDni);
                selectedPerson.OwnedCars.ForEach(el =>
                {
                    if (el.Plate == Cars[index].Plate)
                    {
                        el = newCar;
                    }
                });
            }

            Cars[index] = newCar;

            return "Car updated";
        }
        #endregion

        #region Events
        #endregion
    }
}
