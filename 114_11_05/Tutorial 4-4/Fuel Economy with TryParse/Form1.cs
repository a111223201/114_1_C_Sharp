using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double fuelEconomy;

            // Get the number of kilometers driven from the user.
            if (double.TryParse(milesTextBox.Text, out kms))
            {
                // Get the number of liters used from the user.
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    // Calculate fuel economy.
                    fuelEconomy = kms / liters;
                    // Display the fuel economy.
                    mpgLabel.Text = fuelEconomy.ToString("n2") + " 公里/公升";
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("請輸入有效的公升數。");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("請輸入有效的公里數。");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
