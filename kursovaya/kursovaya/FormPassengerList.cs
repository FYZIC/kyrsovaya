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
    public partial class FormPassengerList : Form
    {
        DataBases DB = new DataBases();
        string filePath = "C:\\Users\\Анна\\Desktop\\RegPassengers.txt";
        RegisteredPassenger remotePassenger = null;
        public FormPassengerList()
        {
            InitializeComponent();

            DB.OpenOrCreatFile(filePath);
            List <RegisteredPassenger> registeredPassengers = DB.ReadingFromDatabase<RegisteredPassenger>();

            for (int i = 0; i < registeredPassengers.Count; i++)
                listBox1.Items.Add(registeredPassengers[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEnter formEnter = new FormEnter();
            formEnter.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            { 
                remotePassenger = (RegisteredPassenger)listBox1.SelectedItem;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                DB.OpenOrCreatFile(filePath);
                DB.DeletingFromDatabase<RegisteredPassenger>(index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (remotePassenger != null)
            {
                DB.SavingToDatabase<RegisteredPassenger>(remotePassenger);
                listBox1.Items.Add(remotePassenger);
                remotePassenger = null;
            }
        }

        private void buttonSearchPas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Contains(textBoxSearch.Text))
                {
                    listBox1.SetSelected(i, true);
                }
            }
        }

        private void FormPassengerList_Load(object sender, EventArgs e)
        {

        }
    }
}
