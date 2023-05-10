using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dent
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            using (DentbaseEntities db = new DentbaseEntities())
            {
                foreach (Пользователи id in db.Пользователи)
                {
                    comboBox1.Items.Add(id.ID_пользователя);

                }
                foreach (Услуги id in db.Услуги)
                {
                    comboBox1.Items.Add(id.ID_услуги);

                }
                foreach (Врачи id in db.Врачи)
                {
                    comboBox3.Items.Add(id.ID_врача);

                }
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentbaseDataSet1.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.dentbaseDataSet1.Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentbaseDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.dentbaseDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentbaseDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.dentbaseDataSet.Пользователи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox1.Text);            
                Пользователи пользователи = (from t in db.Пользователи where t.ID_пользователя == str select t).FirstOrDefault();
                textBox1.Text = пользователи.Фамилия;
                textBox2.Text = пользователи.Имя;
                textBox3.Text = пользователи.Отчество;
                textBox11.Text = пользователи.Номер_телефона;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox1.Text);
                Пользователи пользователи = (from t in db.Пользователи where t.ID_пользователя == str select t).FirstOrDefault();
                пользователи.Фамилия = textBox1.Text;
                пользователи.Имя = textBox2.Text;
                пользователи.Отчество = textBox3.Text;
                пользователи.Дата_рождения = DateTime.Parse(DateOfBirth.Text);
                пользователи.Номер_телефона = textBox11.Text;
                db.SaveChanges();
                MessageBox.Show("Изменения внесены успешно!");



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox1.Text);
                Пользователи пользователи = (from t in db.Пользователи where t.ID_пользователя == str select t).FirstOrDefault();
                db.Пользователи.Remove(пользователи);
                db.SaveChanges();
                comboBox1.Items.Clear();
                foreach (Пользователи id in db.Пользователи)
                {
                    comboBox1.Items.Add(id.ID_пользователя);

                }
            }
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox2.Text);
                Услуги услуги = (from t in db.Услуги where t.ID_услуги == str select t).FirstOrDefault();
                textBox4.Text = услуги.Название_услуги;
                textBox5.Text = Convert.ToString(услуги.Цена);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox2.Text);
                Услуги услуги = (from t in db.Услуги where t.ID_услуги == str select t).FirstOrDefault();
                услуги.Название_услуги = textBox4.Text;
                услуги.Цена = Convert.ToInt32(textBox5.Text);               
                db.SaveChanges();
                MessageBox.Show("Изменения внесены успешно!");



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox2.Text);
                Услуги услуги = (from t in db.Услуги where t.ID_услуги == str select t).FirstOrDefault();
                db.Услуги.Remove(услуги);
                db.SaveChanges();
                comboBox2.Items.Clear();
                foreach (Услуги id in db.Услуги)
                {
                    comboBox2.Items.Add(id.ID_услуги);

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox3.Text);
                Врачи врачи = (from t in db.Врачи where t.ID_врача == str select t).FirstOrDefault();
                textBox8.Text = врачи.Фамилия;
                textBox7.Text = врачи.Имя;
                textBox6.Text = врачи.Отчество;
                textBox9.Text = врачи.Номер_телефона;
                textBox10.Text = врачи.Стаж;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox3.Text);
                Врачи врачи = (from t in db.Врачи where t.ID_врача == str select t).FirstOrDefault();
                врачи.Фамилия = textBox8.Text;
                врачи.Имя = textBox7.Text;
                врачи.Отчество = textBox6.Text;
                врачи.Номер_телефона = textBox9.Text;
                врачи.Стаж = textBox10.Text;
                db.SaveChanges();
                MessageBox.Show("Изменения внесены успешно!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox3.Text);
                Врачи врачи = (from t in db.Врачи where t.ID_врача == str select t).FirstOrDefault();
                db.Врачи.Remove(врачи);

                db.SaveChanges();
                comboBox3.Items.Clear();
                foreach (Врачи id in db.Врачи)
                {
                    comboBox3.Items.Add(id.ID_врача);

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                
                        Услуги услуги = new Услуги { Название_услуги = textBox4.Text, Цена = Convert.ToInt32(textBox5.Text) };
                        db.Услуги.Add(услуги);
                        db.SaveChanges();
                        MessageBox.Show("Данные внесены");

                  

                
            }
        }
    }
}
