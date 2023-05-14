using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrating_activity_01
{
    internal class Car
    {
        #region Attributes
        private string plate;
        private string manufacturer;
        private string model;
        private string year;
        private decimal price;
        private string ownerDni;
        #endregion

        #region Properties
        public string Plate { get { return plate; } set { plate = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Year { get { return year; } set { year = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public string OwnerDni { get { return ownerDni; } set { ownerDni = value; } }
        #endregion

        #region Constructors
        public Car(string plate, string manufacturer, string model, string year, decimal price, Person owner)
        {
            Plate = plate;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Price = price;
            OwnerDni = ownerDni;
        }

        public Car(string plate, string manufacturer, string model, string year, decimal price) : this(plate, manufacturer, model, year, price, null) { }

        public Car(Car newCar) : this(newCar.Plate, newCar.Manufacturer, newCar.Model, newCar.Year, newCar.Price) { }
        #endregion

        #region Destructors
        ~Car()
        {
            Console.WriteLine($"Car with plate {Plate} was destroyed");
        }
        #endregion

        #region Methods
        #endregion

        #region Events
        #endregion
    }
}
