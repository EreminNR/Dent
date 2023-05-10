using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dent
{
    public partial class Form1 : Form
    {
        public static string log;
        public static string pas;
        public static string familia;
        public static string name;
        public static string otchestvo;
        public static int id;
        public Form1()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {

                foreach (Пользователи user in db.Пользователи)
                {

                    if (PhoneNumber.Text == user.Номер_телефона && Password.Text == user.Пароль)
                    {
                        pas = user.Пароль;
                        log = user.Номер_телефона;
                        familia = user.Фамилия;
                        name = user.Имя;
                        otchestvo = user.Отчество;
                        id = user.ID_пользователя;
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        MessageBox.Show("Добро пожаловать, " + user.Имя + "!");
                        mainForm.Show();
                        this.Hide();
                        return;
                     }
                }
                foreach (Администраторы admin in db.Администраторы)
                {

                    if (PhoneNumber.Text == admin.Логин && Password.Text == admin.Пароль)
                    {
                        adminPanel Form = new adminPanel();
                        MessageBox.Show("Вы вошли под именем администратора");
                        Form.Show();
                        this.Hide();
                        return;
                    }
                }
                foreach (Врачи doctor in db.Врачи)
                {

                    if (PhoneNumber.Text == doctor.Номер_телефона && Password.Text == doctor.Пароль)
                    {
                        Doctor Form = new Doctor();
                        MessageBox.Show("Вы вошли под именем врача");
                        Form.Show();
                        this.Hide();
                        return;
                    }
                }

                MessageBox.Show("Номер телефона или пароль указан неверно!");
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}
