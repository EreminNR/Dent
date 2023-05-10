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
    public partial class DoctorAdding : Form
    {
        public DoctorAdding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                Врачи doctor = new Врачи(Lastname.Text, Firstname.Text, Middlename.Text, Experience.Text, PhoneNumber.Text, Password.Text);
                db.Врачи.Add(doctor);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(); 
            this.Hide();
            form.Show();
        }
    }
}
