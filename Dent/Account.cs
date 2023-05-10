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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            textBox1.Text = Form1.familia;
            textBox2.Text = Form1.name;
            textBox3.Text = Form1.otchestvo;
            textBox6.Text = Form1.pas;
            textBox4.Text = Form1.log;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            History form1 = new History();
            form1.Show();
            this.Hide();
        }
    }
}
