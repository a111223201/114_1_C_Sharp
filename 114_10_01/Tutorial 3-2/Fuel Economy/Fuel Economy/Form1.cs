using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 假設有兩個TextBox: milesTextBox, gallonsTextBox
            // 一個Label: resultLabel
            double miles, gallons, mpg;

            if (double.TryParse(milesTextBox.Text, out miles) &&
                double.TryParse(gallonsTextBox.Text, out gallons) &&
                gallons > 0)
            {
                mpg = miles / gallons;
                mpgLabel.Text = $"每加侖英里數: {mpg:F2}";
            }
            else
            {
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
