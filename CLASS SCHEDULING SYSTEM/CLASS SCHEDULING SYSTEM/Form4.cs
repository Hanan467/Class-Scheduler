using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_SCHEDULING_SYSTEM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5A f5 = new Form5A();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4=new Form4();
            f4.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("class-room assigned successfully");
        }
    }
}
