using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    

    public partial class Distanse : Form
    {
        public Distanse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var toMain = new Form1();
            toMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new Culculating();
            calc.DiastanceCalculate(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox4.Text));
            textBox5.Text = Convert.ToString(calc.Dist);
        }
    }
}
