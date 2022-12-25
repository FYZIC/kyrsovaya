using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEnter formEnter = new FormEnter();
            formEnter.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPassengerList formPassengerList = new FormPassengerList();
            formPassengerList.Show();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            DataBases DB = new DataBases();
            DataBases DB1 = new DataBases();

            string filePath = "C:\\Users\\Анна\\Desktop\\Passengers.txt";
            DB.OpenOrCreatFile(filePath);
            List<Passenger> passengers = DB.ReadingFromDatabase<Passenger>();

            string filePath1 = "C:\\Users\\Анна\\Desktop\\RegPassengers.txt";
            DB1.OpenOrCreatFile(filePath1);
            List<RegisteredPassenger> regPassengers = DB1.ReadingFromDatabase<RegisteredPassenger>();

            label4.Text = passengers.Count.ToString();
            label2.Text = regPassengers.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTiketsList formTiketsList = new FormTiketsList();
            formTiketsList.Show();
            this.Close();
        }
    }
}
