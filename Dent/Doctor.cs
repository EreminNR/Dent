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
    public partial class Doctor : Form
    {
        
        public Doctor()
        {
            InitializeComponent();
            using (DentbaseEntities db = new DentbaseEntities())
            {
                foreach (История_записей id in db.История_записей)
                {
                    comboBox1.Items.Add(id.ID_Истории);
                    
                }
            }
            comboBox2.Items.Add("Неактивна");
            comboBox2.Items.Add("Активна");
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentbaseDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.dentbaseDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentbaseDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.dentbaseDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentbaseDataSet.История_записей". При необходимости она может быть перемещена или удалена.
            this.история_записейTableAdapter.Fill(this.dentbaseDataSet.История_записей);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox1.Text);
                История_записей история = (from t in db.История_записей where t.ID_Истории == str select t).FirstOrDefault();
                var polzovatel = история.ID_пользователя;
                var uslugi = история.ID_услуги;
                var vrach = история.ID_врача;
                Пользователи пользователи = (from t in db.Пользователи where t.ID_пользователя == polzovatel select t).FirstOrDefault();
                textBox1.Text = пользователи.Фамилия;
                textBox2.Text = пользователи.Имя;
                textBox3.Text = пользователи.Отчество;
                Услуги услуги = (from t in db.Услуги where t.ID_услуги == uslugi select t).FirstOrDefault();
                textBox4.Text = услуги.Название_услуги;
                Врачи врачи = (from t in db.Врачи where t.ID_врача == vrach select t).FirstOrDefault();
                textBox5.Text = врачи.Имя;
                textBox6.Text = врачи.Отчество;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                int str = Convert.ToInt32(comboBox1.Text);
                История_записей история = (from t in db.История_записей where t.ID_Истории == str select t).FirstOrDefault();
                
                история.СтатусЗаписи = comboBox2.Text;
                
                db.SaveChanges();
                MessageBox.Show("Изменения внесены успешно!");



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor doctor = new Doctor();
            doctor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
