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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            string Id = Convert.ToString(Form1.id);
            using (DentbaseEntities db = new DentbaseEntities())
            {
                foreach (История_записей id in db.История_записей)
                {
                    if (Id == Convert.ToString(id.ID_пользователя) && id.СтатусЗаписи == "Активна")
                    {
                        Врачи врачи = (from t in db.Врачи where t.ID_врача == id.ID_врача select t).FirstOrDefault();
                        Услуги услуги = (from t in db.Услуги where t.ID_услуги == id.ID_услуги select t).FirstOrDefault();
                        label2.Text = ("Запись на прием активна (Врач, услуга): " + врачи.Фамилия + ", " + услуги.Название_услуги);
                    }
                    else
                    {
                        label2.Text = ("Нет активных записей");
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account form1 = new Account();
            form1.Show();
            this.Hide();
        }
    }
}
