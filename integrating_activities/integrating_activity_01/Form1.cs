using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integrating_activity_01
{
    public partial class Form1 : Form
    {
        BusinessManager businessManager = new BusinessManager();
        DataTable peopleDataTable = new DataTable();
        DataTable carsDataTable = new DataTable();
        DataTable ownedCarsDataTable = new DataTable();
        DataTable fullCarsDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(InitializePeopleDataTable());
            Console.WriteLine(InitializePeopleDataGridView());

            Console.WriteLine(InitializeCarsDataTable());
            Console.WriteLine(InitializeCarsDataGridView());

            Console.WriteLine(InitializeCarsOwnedDataTable());
            Console.WriteLine(InitializeCarsOwnedDataGridView());

            Console.WriteLine(InitializeFullCarsDataTable());
            Console.WriteLine(InitializeFullCarsDataGridView());
        }

        #region Events
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            if (isInputValid(groupBoxCar))
            {
                Car newCar = new Car(textBoxPlate.Text, textBoxManufacturer.Text, textBoxModel.Text, textBoxYear.Text, Int32.Parse(textBoxPrice.Text));
                businessManager.AddCar(newCar);
                AddRowCarsDataTable(newCar);
                RefreshFullCarsDataTable(businessManager.GetCars());
            }
        }
        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            if (isInputValid(groupBoxPerson))
            {
                Person newPerson = new Person(textBoxPersonDni.Text, textBoxPersonName.Text, textBoxPersonSurname.Text);
                businessManager.AddPerson(newPerson);
                AddRowPeopleDataTable(newPerson);
            }
        }
        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                int personRowIndex = dataGridViewPeople.SelectedRows[0].Index;
                businessManager.DeletePerson(personRowIndex);
                RefreshPeopleDataTable(businessManager.GetPeople());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedCarRow = dataGridViewCars.SelectedRows[0];
                businessManager.DeleteCar(selectedCarRow.Index);
                RefreshCarsDataTable(businessManager.GetCars());
                RefreshFullCarsDataTable(businessManager.GetCars());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void buttonUpdatePerson_Click(object sender, EventArgs e)
        {
            if (isInputValid(groupBoxPerson))
            {
                int personRowIndex = dataGridViewPeople.SelectedRows[0].Index;
                Person newPerson = new Person(textBoxPersonDni.Text, textBoxPersonName.Text, textBoxPersonSurname.Text);
                businessManager.UpdatePerson(personRowIndex, newPerson);
                RefreshPeopleDataTable(businessManager.GetPeople());
                RefreshFullCarsDataTable(businessManager.GetCars());
            }
        }
        private void buttonUpdateCar_Click(object sender, EventArgs e)
        {
            if (isInputValid(groupBoxCar))
            {
                if (dataGridViewPeople.SelectedRows.Count > 0)
                {
                    int carRowIndex = dataGridViewCars.SelectedRows[0].Index;
                    Car newCar = new Car(textBoxPlate.Text, textBoxManufacturer.Text, textBoxModel.Text, textBoxYear.Text, Int32.Parse(textBoxPrice.Text));
                    businessManager.UpdateCar(carRowIndex, newCar);
                    RefreshCarsDataTable(businessManager.GetCars());
                    RefreshFullCarsDataTable(businessManager.GetCars());

                    DataGridViewRow selectedRow = dataGridViewPeople.SelectedRows[0];
                    List<Car> ownedCars = businessManager.GetOwnedCars(businessManager.GetPersonByIndex(selectedRow.Index).Dni);
                    RefreshCarsOwnedDataTable(ownedCars);
                }
            }
        }

        private void dataGridViewPeople_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPeople.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPeople.SelectedRows[0];
                List<Car> ownedCars = businessManager.GetOwnedCars(businessManager.GetPersonByIndex(selectedRow.Index).Dni);

                RefreshCarsOwnedDataTable(ownedCars);

                HandleTotalValueLabel(selectedRow.Index);
            }
        }
        private void buttonBind_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedPersonRow = dataGridViewPeople.SelectedRows[0];
                DataGridViewRow selectedCarRow = dataGridViewCars.SelectedRows[0];

                businessManager.BindOwnerCar(businessManager.GetPersonByIndex(selectedPersonRow.Index).Dni, businessManager.GetCarByIndex(selectedCarRow.Index).Plate);
                RefreshCarsOwnedDataTable(businessManager.GetOwnedCars(businessManager.GetPersonByIndex(selectedPersonRow.Index).Dni));
                RefreshFullCarsDataTable(businessManager.GetCars());

                HandleTotalValueLabel(selectedPersonRow.Index);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDummyPeopleLoad_Click(object sender, EventArgs e)
        {
            AddDummyPeople();
            RefreshPeopleDataTable(businessManager.GetPeople());
            RefreshFullCarsDataTable(businessManager.GetCars());
        }
        private void buttonDummyCarsLoad_Click(object sender, EventArgs e)
        {
            AddDummyCars();
            RefreshCarsDataTable(businessManager.GetCars());
            RefreshFullCarsDataTable(businessManager.GetCars());
        }
        #endregion

        #region Methods
        private bool isDniValid(string dni)
        {
            Regex dniRegex = new Regex(@"^\d{2}\.\d{3}\.\d{3}$");
            if (dniRegex.IsMatch(dni))
            {
                return true;
            }
            return false;
        }
        private bool isDniDuplicated(string dni)
        {
            if (businessManager.GetPersonByDni(dni) != null)
            {
                return true;
            }
            return false;
        }
        private bool isPlateDuplicated(string plate)
        {
            if (businessManager.GetCarByPlate(plate) != null)
            {
                return true;
            }
            return false;

        }
        private bool isInputValid(GroupBox groupBox)
        {
            try
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is TextBox)
                    {
                        if (control.Text == "") throw new Exception("Input can not be empty");
                        else if (control == textBoxPlate && isPlateDuplicated(textBoxPlate.Text)) throw new Exception("Car plate can not be duplicated");
                        else if (control == textBoxPersonDni)
                        {
                            if (!isDniValid(textBoxPersonDni.Text)) throw new Exception("DNI format is not valid");
                            if (isDniDuplicated(textBoxPersonDni.Text)) throw new Exception("DNI can not be duplicated");
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string InitializePeopleDataTable()
        {
            peopleDataTable.Columns.Add("DNI");
            peopleDataTable.Columns.Add("Name");
            peopleDataTable.Columns.Add("Surname");

            return "peopleDataTable initialized";
        }
        private string InitializePeopleDataGridView()
        {
            dataGridViewPeople.DataSource = peopleDataTable;

            dataGridViewPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPeople.MultiSelect = false;
            dataGridViewPeople.ReadOnly = true;
            dataGridViewPeople.ColumnHeadersVisible = true;
            dataGridViewPeople.RowHeadersVisible = true;

            return "peopleDataGridView initialized";
        }
        private string AddRowPeopleDataTable(Person newPerson)
        {
            DataRow dataRow = peopleDataTable.NewRow();
            dataRow["DNI"] = newPerson.Dni;
            dataRow["Name"] = newPerson.Name;
            dataRow["Surname"] = newPerson.Surname;
            peopleDataTable.Rows.Add(dataRow);
            return "Row added successfully to peopleDataTable";
        }
        private string RefreshPeopleDataTable(List<Person> peopleList)
        {
            peopleDataTable.Clear();
            foreach (Person person in peopleList)
            {
                DataRow dataRow = peopleDataTable.NewRow();
                dataRow["DNI"] = person.Dni;
                dataRow["Name"] = person.Name;
                dataRow["Surname"] = person.Surname;
                peopleDataTable.Rows.Add(dataRow);
            }
            return "PeopleDataTable refreshed";
        }

        private string InitializeCarsDataTable()
        {
            carsDataTable.Columns.Add("Plate");
            carsDataTable.Columns.Add("Manufacturer");
            carsDataTable.Columns.Add("Model");
            carsDataTable.Columns.Add("Year");
            carsDataTable.Columns.Add("Price");

            return "carsDataTable initialized";
        }
        private string InitializeCarsDataGridView()
        {
            dataGridViewCars.DataSource = carsDataTable;

            dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCars.MultiSelect = false;
            dataGridViewCars.ReadOnly = true;
            dataGridViewCars.ColumnHeadersVisible = true;
            dataGridViewCars.RowHeadersVisible = true;

            return "carsDataGridView initialized";
        }
        private string AddRowCarsDataTable(Car newCar)
        {
            DataRow dataRow = carsDataTable.NewRow();
            dataRow["Plate"] = newCar.Plate;
            dataRow["Manufacturer"] = newCar.Manufacturer;
            dataRow["Model"] = newCar.Model;
            dataRow["Year"] = newCar.Year;
            dataRow["Price"] = newCar.Price;

            carsDataTable.Rows.Add(dataRow);
            return "Row added successfully to carsDataTable";
        }
        private string RefreshCarsDataTable(List<Car> carsList)
        {
            carsDataTable.Clear();
            foreach (Car car in carsList)
            {
                DataRow dataRow = carsDataTable.NewRow();
                dataRow["Plate"] = car.Plate;
                dataRow["Manufacturer"] = car.Manufacturer;
                dataRow["Model"] = car.Model;
                dataRow["Year"] = car.Year;
                dataRow["Price"] = car.Price;

                carsDataTable.Rows.Add(dataRow);
            }
            return "PeopleDataTable refreshed";
        }

        private string InitializeCarsOwnedDataTable()
        {
            ownedCarsDataTable.Columns.Add("Plate");
            ownedCarsDataTable.Columns.Add("Manufacturer");
            ownedCarsDataTable.Columns.Add("Model");
            ownedCarsDataTable.Columns.Add("Year");
            ownedCarsDataTable.Columns.Add("Price");

            return "ownedCarsDataTable initialized";
        }
        private string InitializeCarsOwnedDataGridView()
        {
            dataGridViewOwnedCars.DataSource = ownedCarsDataTable;

            dataGridViewOwnedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOwnedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOwnedCars.MultiSelect = false;
            dataGridViewOwnedCars.ReadOnly = true;
            dataGridViewOwnedCars.ColumnHeadersVisible = true;
            dataGridViewOwnedCars.RowHeadersVisible = true;

            return "dataGridViewOwnedCars initialized";
        }
        private string RefreshCarsOwnedDataTable(List<Car> carsList)
        {
            ownedCarsDataTable.Clear();
            foreach (Car car in carsList)
            {
                DataRow dataRow = ownedCarsDataTable.NewRow();
                dataRow["Plate"] = car.Plate;
                dataRow["Manufacturer"] = car.Manufacturer;
                dataRow["Model"] = car.Model;
                dataRow["Year"] = car.Year;
                dataRow["Price"] = car.Price;

                ownedCarsDataTable.Rows.Add(dataRow);
            }
            return "PeopleDataTable refreshed";
        }

        private string InitializeFullCarsDataTable()
        {
            fullCarsDataTable.Columns.Add("Manufacturer");
            fullCarsDataTable.Columns.Add("Year");
            fullCarsDataTable.Columns.Add("Model");
            fullCarsDataTable.Columns.Add("Plate");
            fullCarsDataTable.Columns.Add("OwnerDni");
            fullCarsDataTable.Columns.Add("OwnerNames");

            return "fullCarsDataTable initialized";
        }
        private string InitializeFullCarsDataGridView()
        {
            dataGridViewFullCars.DataSource = fullCarsDataTable;

            dataGridViewFullCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFullCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFullCars.MultiSelect = false;
            dataGridViewFullCars.ReadOnly = true;
            dataGridViewFullCars.ColumnHeadersVisible = true;
            dataGridViewFullCars.RowHeadersVisible = true;

            return "dataGridViewFullCars initialized";
        }
        private string RefreshFullCarsDataTable(List<Car> carsList)
        {
            fullCarsDataTable.Clear();
            foreach (Car car in carsList)
            {
                DataRow dataRow = fullCarsDataTable.NewRow();
                dataRow["Manufacturer"] = car.Manufacturer;
                dataRow["Year"] = car.Year;
                dataRow["Model"] = car.Model;
                dataRow["Plate"] = car.Plate;
                dataRow["OwnerDni"] = car.OwnerDni;
                dataRow["OwnerNames"] = businessManager.GetPersonByDni(car.OwnerDni)?.Name + businessManager.GetPersonByDni(car.OwnerDni)?.Surname ?? "";

                fullCarsDataTable.Rows.Add(dataRow);
            }
            return "PeopleDataTable refreshed";
        }

        private void HandleTotalValueLabel(int index)
        {
            List<Car> ownedCars = businessManager.GetOwnedCars(businessManager.GetPersonByIndex(index).Dni);
            decimal totalCarsValue = 0;
            ownedCars.ForEach(el => totalCarsValue += el.Price);

            labelTotalCarsValue.Text = $"Valor de autos: {totalCarsValue}";
        }

        private void AddDummyPeople()
        {
            for (int i = 0; i < 10; i++)
            {
                Person dummyPerson = new Person($"{i}{i}.{i}{i}{i}.{i}{i}{i}", $"{i}{i}{i}", $"{i}{i}{i}");
                businessManager.AddPerson(dummyPerson);
            }

        }
        private void AddDummyCars()
        {
            for (int i = 0; i < 10; i++)
            {
                Car dummyCar = new Car($"{i}{i}{i}", $"{i}{i}{i}", $"{i}{i}{i}", $"{i}{i}{i}", i);
                businessManager.AddCar(dummyCar);
            }

        }
        #endregion
    }
}
