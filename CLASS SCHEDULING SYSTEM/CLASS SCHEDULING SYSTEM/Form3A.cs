﻿using System;
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
    public partial class Form3A : Form
    {
        public Form3A()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("instructor assigned sucessfully!");
            this.Hide();
            Form4A f4 = new Form4A();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3A f3 = new Form3A();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4A f4 = new Form4A();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5A f5 = new Form5A();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6A f6 = new Form6A();
            f6.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}