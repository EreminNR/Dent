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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                Пользователи user = new Пользователи(Lastname.Text, Firstname.Text, Middlename.Text, DateTime.Parse(DateOfBirth.Text), Password.Text, PhoneNumber.Text);
                db.Пользователи.Add(user);
                db.SaveChanges();
            }
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
