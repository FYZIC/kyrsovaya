using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class FormLuggage : Form
    {
        FormRegistration formRegistration;
        FormExtraLug formExtraLug = null;
        string surname = null;
        string patronymic = null;
        string name = null;
        string gender = null;
        string birth = null;
        string luggage = null;
        string handLug = null;
        string passportSeries = null;
        string passportNumber = null;
        string flight = "5";
        string boadPasNumber = null;
        string seat = null;
        public string extraLug = null;
        string registrationTime = DateTime.Now.ToString("yyyy.MM.dd, HH.mm");

        public FormLuggage(FormRegistration owner)
        {
            InitializeComponent();
            formRegistration = owner;
            name = formRegistration.textBoxName.Text;
            surname = formRegistration.textBoxSurname.Text;
            patronymic = formRegistration.textBoxPatronymic.Text;
            passportNumber = formRegistration.maskedTextBoxPusNum.Text;
            passportSeries = formRegistration.maskedTextBoxPasSer.Text;
            gender = formRegistration.comboBoxGender.Text;
            birth = formRegistration.dateTimePicker1.Text;
            seat = formRegistration.seat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxHandLag.Text == "")
            {
                MessageBox.Show("Не добавлен вес ручной клади, если ручной клади нет, введите \"0\"");
            }
            else if (Convert.ToInt32(textBoxHandLag.Text) > 5)
            {
                MessageBox.Show("Вес ручной клади превышает возможный");
            }
            if (textBoxLag.Text == "")
            {
                MessageBox.Show("Не добавлен вес багажа, если багажа нет, введите \"0\"");
            }
            else if (Convert.ToInt32(textBoxLag.Text) > 10)
            {
                MessageBox.Show("Вес багажа превышает возможный");
            }
            else
            {
                luggage = textBoxLag.Text;
                handLug = textBoxHandLag.Text;

                if (formExtraLug != null) formExtraLug.Close();

                bool flag = false;

                DataBases DB = new DataBases();
                string filePath = "C:\\Users\\Анна\\Desktop\\RegPassengers.txt";
                DB.OpenOrCreatFile(filePath);

                List<RegisteredPassenger> regPass = DB.ReadingFromDatabase<RegisteredPassenger>();
                Random rnd = new Random();

                while (flag == false)
                {
                    int BoadPass = rnd.Next(111111111, 999999999);
                    boadPasNumber = BoadPass.ToString();

                    if (regPass.Count != 0)
                    {
                        foreach (var regPas in regPass)
                        {
                            if (boadPasNumber == regPas.BoadPassNumber) flag = false;
                            else flag = true;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (extraLug == null) extraLug = "0";

                RegisteredPassenger newRegisteredPassenger = new RegisteredPassenger(passportSeries, passportNumber, surname, name, patronymic, gender, birth, flight, boadPasNumber, seat, handLug, luggage, extraLug, registrationTime);
                DB.SavingToDatabase<RegisteredPassenger>(newRegisteredPassenger);

                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxHandLag.Text == "")
            {
                textBoxHandLag.Text = "0";
            }
            else if (Convert.ToInt32(textBoxHandLag.Text) > 5)
            {
                MessageBox.Show("Вес ручной клади превышает возможный");
            }
            else if (textBoxLag.Text == "")
            {
                textBoxLag.Text = "0";
            }
            else if (Convert.ToInt32(textBoxLag.Text) > 10)
            {
                MessageBox.Show("Вес багажа превышает возможный");
            }
            else if (textBoxLag.Text == "" || textBoxLag.Text == "0")
            {
                MessageBox.Show("Ошибка, не добавлен основной багаж");
            }
            else
            {
                formExtraLug = new FormExtraLug(this);
                formExtraLug.Show();
            }
        }

        private void FormLuggage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEnter formEnter = new FormEnter();
            formEnter.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Close();
        }
    }
}
