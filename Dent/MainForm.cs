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
    public partial class MainForm : Form
    {
        public string hour = "";
        public string date = "";
        public MainForm()
        {
            InitializeComponent();
           using (DentbaseEntities db = new DentbaseEntities())
           {

                foreach (Врачи doctor in db.Врачи)
                {
                    comboBox1.Items.Add(FullName.Doctor(doctor));
                }
                var firstTarget = false;
                var secondTarget = false;
                var ThirdTarget = false;
                var firstDate = "";
                var counter = 1;
                foreach (Записи time in db.Записи)
                {
                    var time1 = (from t in db.Записи
                                 where t.ID_Записи == 1
                                 select t).FirstOrDefault();
                   firstDate = ReverseDate(DateTime.Parse(Convert.ToString(time1.Дата)).ToShortDateString());
                }
                var length = db.Записи.ToList().Count();
                foreach (Записи time in db.Записи)
                {
                    for(var i = 1; i <= length; i++)
                    { 

                        var time1 = (from t in db.Записи
                                       where t.ID_Записи == i
                                       select t).FirstOrDefault();
                        var check = DateTime.Parse(Convert.ToString(time1.Дата)).ToShortDateString();
                        
                        if (firstTarget == true) goto first;
                        if (secondTarget == true) goto second;
                        if (ThirdTarget == true) goto third;
                        if (firstDate == ReverseDate(check))
                            {
                                groupBox1.Text = ReverseDate(check);
                            }
                        if (firstDate != ReverseDate(check))
                        {
                            groupBox2.Text = ReverseDate(check);
                            firstTarget = true;
                        }
                    first:
                        if (firstDate != ReverseDate(check) && groupBox2.Text != ReverseDate(check))
                        {
                            groupBox3.Text = ReverseDate(check);
                            firstTarget = false;
                            secondTarget = true;
                        }
                    second:
                        button9.Text = "";
                        if (firstDate != ReverseDate(check) && groupBox2.Text != ReverseDate(check) && groupBox3.Text != ReverseDate(check))
                        {
                            groupBox4.Text = ReverseDate(check);
                            secondTarget = false;
                            ThirdTarget = true;
                        }
                    third:
                        if (firstDate != ReverseDate(check) && groupBox2.Text != ReverseDate(check) && groupBox3.Text != ReverseDate(check) && groupBox4.Text != ReverseDate(check))
                        {
                            groupBox5.Text = ReverseDate(check);

                        }
                        check = DateTime.Parse(Convert.ToString(time1.Дата)).ToShortDateString();
                        if (ReverseDate(check) == groupBox1.Text && i == counter && button3.Text == "")
                        {
                            button3.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button3.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button3.Text == "") button3.Hide();
                        if (ReverseDate(check) == groupBox1.Text && i == counter && button3.Text == "")
                        {
                            button4.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button4.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button4.Text == "") button4.Hide();
                        if (ReverseDate(check) == groupBox1.Text && i == counter && button3.Text == "")
                        {
                            button5.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button5.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button5.Text == "") button5.Hide();
                        if (ReverseDate(check) == groupBox1.Text && i == counter && button3.Text == "")
                        {
                            button6.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button6.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button6.Text == "") button6.Hide();
                        if (ReverseDate(check) == groupBox2.Text && i == counter && button7.Text =="")
                        {
                            button7.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button7.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button7.Text == "") button7.Hide();
                        if (ReverseDate(check) == groupBox2.Text && i == counter && button8.Text == "")
                        {
                            button8.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button8.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button8.Text == "") button8.Hide();
                        if (ReverseDate(check) == groupBox2.Text && i == counter && button9.Text == "")
                        {
                            button9.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button9.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button9.Text == "") button9.Hide();
                        if (ReverseDate(check) == groupBox2.Text && i == counter && button10.Text == "")
                        {
                            button10.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button10.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button10.Text == "") button10.Hide();
                        if (ReverseDate(check) == groupBox3.Text && i == counter && button11.Text == "")
                        {
                            button11.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button11.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button11.Text == "") button11.Hide();
                        if (ReverseDate(check) == groupBox3.Text && i == counter && button12.Text == "")
                        {
                            button12.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button12.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button12.Text=="") button12.Hide();
                        if (ReverseDate(check) == groupBox3.Text && i == counter && button13.Text == "")
                        {
                            button13.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button13.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button13.Text == "") button13.Hide();
                        if (ReverseDate(check) == groupBox3.Text && i == counter && button14.Text == "")
                        {
                            button14.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button14.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button14.Text == "") button14.Hide();
                        if (ReverseDate(check) == groupBox4.Text && i == counter && button15.Text == "")
                        {
                            button15.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button15.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button15.Text == "") button15.Hide();
                        if (ReverseDate(check) == groupBox4.Text && i == counter && button16.Text == "")
                        {
                            button16.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button16.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button16.Text == "") button16.Hide();
                        if (ReverseDate(check) == groupBox4.Text && i == counter && button17.Text == "")
                        {
                            button17.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button17.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button17.Text == "") button17.Hide();
                        if (ReverseDate(check) == groupBox4.Text && i == counter && button18.Text == "")
                        {
                            button18.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button18.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button18.Text == "") button18.Hide();
                        if (ReverseDate(check) == groupBox5.Text && i == counter && button19.Text == "")
                        {
                            button19.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button19.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button19.Text == "") button19.Hide();
                        if (ReverseDate(check) == groupBox5.Text && i == counter && button20.Text == "")
                        {
                            button20.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button20.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button20.Text == "") button20.Hide();
                        if (ReverseDate(check) == groupBox5.Text && i == counter && button21.Text == "")
                        {
                            button21.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button21.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button21.Text == "") button21.Hide();
                        if (ReverseDate(check) == groupBox5.Text && i == counter && button22.Text == "")
                        {
                            button22.Show();
                            var ConvertingDate = DateTime.Parse(Convert.ToString(time1.Дата));
                            var ButtonTime = ConvertingDate.ToShortTimeString();
                            button22.Text = Convert.ToString(ButtonTime);
                            counter++;
                        }
                        else if (button22.Text == "") button22.Hide();
                    }
                }
                
           }
        }
        string ReverseDate(string date)
        {   
            string [] splited = date.Split('.');
            string reversedDate = splited[1] + "." + splited[0];
            return reversedDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History form1 = new History();
            form1.Show();
            this.Hide();

        }

        private void admin_Click(object sender, EventArgs e)
        {
            AddingDate form = new AddingDate();
            form.Show();
            this.Hide();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) 
            {

                if(item is GroupBox)
                {
                    ((GroupBox)item).MouseHover += GbHover;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                hour = ((Button)sender).Text;
                Записи time = new Записи(DateTime.Parse(DateCreater(date, hour)));
                db.Записи.Add(time);
                db.SaveChanges();
                MessageBox.Show(date);
            }
        }
        private void GbHover(object sender, EventArgs e)
        {
            date = ((GroupBox)sender).Text;
        }
        string DateCreater(string day, string date)
        {
            return Convert.ToString(DateTime.Now.Year) + "." + day + " " + date;
        }
        void adding(object a)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                var selectedTime = 0;
                var selectedDoctor = 0;
                var currentUser = 0;
                foreach (Пользователи x in db.Пользователи)
                {
                    var b = (from t in db.Пользователи where t.Номер_телефона == Form1.log select t).FirstOrDefault();
                    currentUser = b.ID_пользователя;
                }
                hour = ((Button)a).Text;
                var sd = DateTime.Parse(DateCreater(date, hour));
                foreach (Записи x in db.Записи) {
                    var b  = (from t in db.Записи where t.Дата == sd select t).FirstOrDefault();
                    selectedTime = b.ID_Записи;
                        }
                foreach (Врачи x in db.Врачи)
                {
                    var f = comboBox1.Text.Split(' ');
                    var first = f[0];
                    var b = (from t in db.Врачи where t.Фамилия == first select t).FirstOrDefault();
                    selectedDoctor = b.ID_врача;

                }
                История_записей time = new История_записей(1, selectedTime, currentUser, selectedDoctor);
                db.История_записей.Add(time);
                db.SaveChanges();
                MessageBox.Show("Вы успешно записались на " + sd);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            adding(sender as Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.Show();
            this.Hide();
        }
    }
}
