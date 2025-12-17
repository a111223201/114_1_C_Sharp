using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CupsToOunces method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces.
     

        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups;       // To hold the number of cups
            double ounces;    // To hold the number of ounces

            if(double.TryParse(cupsTextBox.Text, out cups))
            {
                // Call the CupsToOunces method to
                // perform the conversion.
                ounces = CupsToOunces(cups);
                // Display the result.
                ouncesLabel.Text = ounces.ToString("n2") + " 液體盎司"; // 繁體中文單位
            }
            else
            {
                // Display an error message.
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤"); // 繁體中文錯誤訊息
            }
        }

        private double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
