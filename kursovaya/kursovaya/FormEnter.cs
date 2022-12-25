using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
            BackgroundImage = Image.FromStream(new WebClient().OpenRead("C:\\Users\\Анна\\Desktop\\download2.gif"));
            ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;

            DataBases DB = new DataBases();

            string filePath = "C:\\Users\\Анна\\Desktop\\loginPas.txt";
            DB.OpenOrCreatFile(filePath);
            List<Worker> workers = DB.ReadingFromDatabase<Worker>();

                foreach (var worker in workers)
                {
                    if (textBoxPassword.Text == worker.Password && textBoxLogin.Text == worker.Login)
                    {
                        FormMenu formMenu = new FormMenu();
                        formMenu.Show();
                        this.Hide();
                        flag = true;
                        break;
                    }
                }

            if (flag == false)
            {
                MessageBox.Show("Введен неверный логин или пароль");
            }
        }



        private void FormEnter_Load(object sender, EventArgs e)
        {

        }
    }
}
