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
    public partial class FormExtraLug : Form
    {
        FormLuggage formLuggage;
        string extraLug = null;

        public FormExtraLug(FormLuggage owner)
        {
            InitializeComponent();
            formLuggage = owner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxExtraLug.Text == "" || textBoxExtraLug.Text == "0")
            {
                MessageBox.Show("Вы не добавили вес багажа");
            }
            else if (Convert.ToInt32(textBoxExtraLug.Text) > 10)
            {
                MessageBox.Show("Вес багажа превышает возможный");
            }
            else
            { 
                extraLug = textBoxExtraLug.Text;
                formLuggage.extraLug = extraLug;
                this.Close();
            }
        }

        private void FormExtraLug_Load(object sender, EventArgs e)
        {

        }
    }
}
