using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_01_thermometer
{
    public partial class Form1 : Form
    {
        Thermometer thermometer;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            thermometer = new Thermometer();
            thermometer.DangerTemperature += SubscribedDangerTemperature; // Event subscription
        }

        #region Classes
        public class Thermometer
        {
            #region Fields
            private int temperature;
            private readonly int MAX_TEMPERATURE = 100;
            #endregion
            #region Properties
            public int Temperature
            {
                get { return temperature; }
                set {
                    if (value > MAX_TEMPERATURE)
                    {
                        DangerTemperature?.Invoke(this, new DangerTemperatureEventArgs(MAX_TEMPERATURE, Temperature));
                    }
                    temperature = value;
                } // Is at least 1 ??? subscribed to the event?
            }
            #endregion
            #region Events
            public event EventHandler<DangerTemperatureEventArgs> DangerTemperature;
            #endregion
            #region Methods
            #endregion
        }

        public class DangerTemperatureEventArgs : EventArgs
        {
            #region Fields
            private int dangerTempertaure, inputTempertaure;

            #endregion
            #region Constructors
            public DangerTemperatureEventArgs(int dangerTemperature, int inputTemperature)
            {
                DangerTemperature = dangerTemperature;
                InputTemperature = inputTemperature;
            }
            #endregion
            #region Properties
            public int DangerTemperature
            {
                get { return dangerTempertaure; } set { dangerTempertaure = value; }
            }
            public int InputTemperature
            {
                get { return inputTempertaure; }
                set { inputTempertaure = value; } 
            }
            public int TemperaturesDifference { get { return DangerTemperature - InputTemperature; }}
            #endregion
        }
        #endregion

        #region Methods
        private void SubscribedDangerTemperature(object sender, DangerTemperatureEventArgs e) // Updated this to use my class inner stuff
        {
            Console.WriteLine("Danger!" + e.DangerTemperature.ToString() + e.TemperaturesDifference.ToString());
        }
        #endregion

        #region Events
        private void buttonAssignTemperature_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTemperature.Text, out int temperature))
            {
                thermometer.Temperature = temperature;
            }
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            thermometer.DangerTemperature += SubscribedDangerTemperature; // If you subscribe 100 times to an event, the method will be executed 100 times
        }

        private void buttonUnsubscribe_Click(object sender, EventArgs e)
        {
            thermometer.DangerTemperature -= SubscribedDangerTemperature;
        }
        #endregion

    }
}
