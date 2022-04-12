using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Middle : Form
    {
        public Middle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var toMain = new Form1();
            toMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mid = new Culculating();
            mid.calculateMiddle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox4.Text));
            textBox5.Text = mid.MiddleCulc;
        }
    }
}
