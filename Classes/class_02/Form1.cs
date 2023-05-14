using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Mammal // Abstract classes can't be instantiated
        {
            public abstract string Sing(); // Only abstract classes can implement abstract methods. Abstracts doesn't need to have an implementation
            public virtual string WhatAmI() { return "I'm a mammal"; } // Can be seen as a "default" if it's not overrided
        }

        public class Cow : Mammal
        {
            public override string Sing() // Is mandatory as i'ts inheritating from Mammal
            {
                return "Mooooooooo";
            }
            public override string WhatAmI() { return "I'm a cow"; }
        }

        public sealed class Dog: Mammal { public override string Sing() { return "Guau"; } }

        //public class Pug : Dog { } Sealed classes can't be inherited from

        public abstract class Cetacean : Mammal
        {
            // Sing() is not mandatory because Cetacean is abstract too
        }

        public class Whale : Cetacean
        {
            public override string Sing() { { return  "Ndeah"; } }
        }
    }
}
