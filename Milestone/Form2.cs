using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cars = { "2013 Tesla Model S 89000", "2020 Lamborghini Huracan 2200000", "2015 Honda Civic 15000" };
            List<string> list = new List<string>(cars.ToList());
            Console.WriteLine("All current Inventory");


            for (int i = 0; i < cars.Length; i++)
            {
                MessageBox.Show(cars[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            MessageBox.Show("you said were doing "+input+ " Thank you for your feedback");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The current interest rate for new cars is 2.58%");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dreamCar = textBox2.Text;

            MessageBox.Show("You entered " + dreamCar + "We will look for one to add!");
        }
    }
}
