using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_much_Insurance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void caculate_Click(object sender, EventArgs e)
        {
            double replacement_of_a_building;

            replacement_of_a_building = double.Parse(textBox1.Text);

            double the_minimum_amount_of_insurance;

            the_minimum_amount_of_insurance = replacement_of_a_building *0.8;

            Result.Text = the_minimum_amount_of_insurance.ToString("C");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
