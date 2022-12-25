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
    public partial class FormRegistration : Form
    {
        public string seat = null;
        public FormRegistration()
        {
            InitializeComponent();
            comboBoxGender.Items.Add("мужской");
            comboBoxGender.Items.Add("женский");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string seat_pos = null;
            string seat_num = null;

            if (dataGridViewSeat[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.AliceBlue || dataGridViewSeat[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Red)
            {
                if (e.ColumnIndex == 1)
                {
                    seat_pos = "A";
                }
                else if (e.ColumnIndex == 2)
                {
                    seat_pos = "B";
                }
                else if (e.ColumnIndex == 3)
                {
                    seat_pos = "C";
                }
                else if (e.ColumnIndex == 5)
                {
                    seat_pos = "D";
                }
                else if (e.ColumnIndex == 6)
                {
                    seat_pos = "E";
                }
                else if (e.ColumnIndex == 7)
                {
                    seat_pos = "F";
                }

                seat_num = e.RowIndex.ToString();

                seat = seat_pos + seat_num;
            }
            
        }

        private void FormRegistration_Load_1(object sender, EventArgs e)
        {
            dataGridViewSeat.AllowUserToAddRows = false;

            DataTable table = new DataTable();
            dataGridViewSeat.DataSource = table;

            for (int i = 0; i < 9; i++)
            {
                dataGridViewSeat.Columns.AddRange(new DataGridViewColumn[] { new DataGridViewButtonColumn() });
                for (int j = 0; j < 3; j++)
                {
                    table.Rows.Add();
                    dataGridViewSeat.Columns[i].Width = 20;
                    dataGridViewSeat.Rows[j].Height = 20;
                }
            }

            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ((j > 0 && j < 4 && i > 0) || (j > 4 && j < 8 && i > 0))
                    {

                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridViewSeat.Rows[i].Cells[j];
                        buttonCell.FlatStyle = FlatStyle.Popup;
                        buttonCell.Style.BackColor = System.Drawing.Color.AliceBlue;
                        DataBases DB = new DataBases();
                        string filePath = "C:\\Users\\Анна\\Desktop\\RegPassengers.txt";
                        DB.OpenOrCreatFile(filePath);
                        List<RegisteredPassenger> seats = DB.ReadingFromDatabase<RegisteredPassenger>();
                        int ColumnIndex = 0;
                        int RowIndex = 0;
                        foreach (var seat1 in seats)
                        {
                            if (seat1.Seat != null)
                            {
                                char a = seat1.Seat[1];
                                if (seat1.Seat[0] == 'A')
                                {
                                    ColumnIndex = 1;
                                }
                                else if (seat1.Seat[0] == 'B')
                                {
                                    ColumnIndex = 2;
                                }
                                else if (seat1.Seat[0] == 'C')
                                {
                                    ColumnIndex = 3;
                                }
                                else if (seat1.Seat[0] == 'D')
                                {
                                    ColumnIndex = 5;
                                }
                                else if (seat1.Seat[0] == 'E')
                                {
                                    ColumnIndex = 6;
                                }
                                else if (seat1.Seat[0] == 'F')
                                {
                                    ColumnIndex = 7;
                                }
                                RowIndex = a - '0';
                                dataGridViewSeat[ColumnIndex, RowIndex].Style.BackColor = Color.Red;
                            }
                        }
                    }
                    if ((j == 0 || j == 8) && i > 0)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = i;
                    }
                    if (i == 0 && j == 1)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = "A";
                    }
                    if (i == 0 && j == 2)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = "B";
                    }
                    if (i == 0 && j == 3)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = "C";
                    }
                    if (i == 0 && j == 5)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = "D";
                    }
                    if (i == 0 && j == 6)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = "E";
                    }
                    if (i == 0 && j == 7)
                    {
                        dataGridViewSeat.Rows[i].Cells[j].Value = "F";
                    }
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int counter = 0;
            DataBases DB = new DataBases();
            DataBases DB1 = new DataBases();

            string filePath = "C:\\Users\\Анна\\Desktop\\Passengers.txt";
            DB.OpenOrCreatFile(filePath);
            List<Passenger> passengers = DB.ReadingFromDatabase<Passenger>();

            foreach (var passenger in passengers)
            {
                counter++;
                if (maskedTextBoxPasSer.Text == passenger.PassportSeries && maskedTextBoxPusNum.Text == passenger.PassportNumber && textBoxSurname.Text == passenger.Surname && textBoxName.Text == passenger.Name && textBoxPatronymic.Text == passenger.Patronymic && comboBoxGender.Text == passenger.Gender && dateTimePicker1.Text == passenger.Birth && passenger.Flight == "5")
                {
                    flag = 1;
                    string filePath1 = "C:\\Users\\Анна\\Desktop\\RegPassengers.txt";
                    DB1.OpenOrCreatFile(filePath1);
                    List<RegisteredPassenger> regPassengers = DB1.ReadingFromDatabase<RegisteredPassenger>();
                    if (seat == null)
                    {
                        MessageBox.Show("Место не выбрано");
                        flag = 2;
                    }
                    foreach (var regPassenger in regPassengers)
                    {
                        if (maskedTextBoxPasSer.Text == regPassenger.PassportSeries && maskedTextBoxPusNum.Text == regPassenger.PassportNumber)
                        {
                            MessageBox.Show("Пассажир уже зарегистрирован");
                            flag = 2;
                        }
                        else if (seat == regPassenger.Seat)
                        {
                            MessageBox.Show("Выбранное место уже занято");
                            flag = 2;
                        }
                    }
                    if (flag == 1)
                    {
                        FormLuggage formLuggage = new FormLuggage(this);
                        formLuggage.Show();
                        this.Close();
                    }
                }
                if (flag == 0 && counter == passengers.Count && passenger.Flight == "5")
                {
                    MessageBox.Show("Пассажир не найден");
                }
                if (flag == 0 && counter == passengers.Count && passenger.Flight != "5")
                {
                    MessageBox.Show("Неверная стойка регистрации, билет куплен на другой рейс");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEnter formEnter = new FormEnter();
            formEnter.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }
    }
}
