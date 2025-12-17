using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.


        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay;
            decimal bonus;
            decimal contribution;
            // Validate the user input.
            if (InputIsValid(out grossPay, out bonus))
            {
                // Calculate the contribution.
                contribution = (grossPay + bonus) * CONTRIB_RATE;
                // Display the contribution.
                contributionLabel.Text = "僱員供款金額：" + contribution.ToString("c");
            }
            else
            {
                // Display an error message.
                MessageBox.Show("請輸入有效的數字。");
            }
        }

        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {
            bool valid = true;
            // Try to convert the gross pay.
            if (!decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                valid = false;
            }
            // Try to convert the bonus.
            if (!decimal.TryParse(bonusTextBox.Text, out bonus))
            {
                valid = false;
            }
            return valid;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
