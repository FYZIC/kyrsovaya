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
    public partial class FormTiketsList : Form
    {
        DataBases DB = new DataBases();
        string filePath = "C:\\Users\\Анна\\Desktop\\Passengers.txt";
        public FormTiketsList()
        {
            InitializeComponent();

            DB.OpenOrCreatFile(filePath);
            List<RegisteredPassenger> registeredPassengers = DB.ReadingFromDatabase<RegisteredPassenger>();

            for (int i = 0; i < registeredPassengers.Count; i++)
                listBox1.Items.Add(registeredPassengers[i]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBox1.SetSelected(i, true);
                }
            }
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

        private void FormTiketsList_Load(object sender, EventArgs e)
        {

        }
    }
}
