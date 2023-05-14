using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_01
{
    internal class Alumn
    {
        #region Fields
        private string name;
        #endregion
        #region Properties
        public string Name // Explicit property
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname { get; set; } // Explicit property
        #endregion
        #region Constructors
        // Each class has an implicit constructor function with empty parms which will be "explicited" here
        // Where, we're overriding/overload/parametric polimorfism the constructor method (same method name, different sign (parms and types))
        public Alumn() { }
        public Alumn(string name) :this() // This will look for a constructor with no parms
        {
            Name = name;
        }
        public Alumn(string name, string surname): this(name)
        {
            Surname = surname;
        }
        #endregion
        #region Destructors
        ~Alumn() // Last function to be executed when an object ends it life cycle. It's invoked by GarbageCollector
        {
            Console.WriteLine("I'm Bob the deconstructor");
        }
        #endregion
        #region Events // This will be seen int class_01_thermometer
        #endregion
        #region Methods
        public void PrintToConsole()
        {
            Console.WriteLine("Cumbia!");
        }
        #endregion
    }
}
