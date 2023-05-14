using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_01
{
    public partial class Form1 : Form
    {
        Alumn alumn;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCreateAlumn_Click(object sender, EventArgs e)
        {
            alumn = new Alumn();
        }

        private void ButtonAddName_Click(object sender, EventArgs e)
        {
            try
            {
                alumn.Name = TextBoxName.Text;
                alumn.Surname = TextBoxSurname.Text;
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonDisplayData_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Name:" + alumn.Name + "Surname:" + alumn.Surname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
