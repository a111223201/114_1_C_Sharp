using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        const decimal BananaCalories = 115m;
        const decimal AppleCalories = 80m;
        const decimal OrangeCalories = 90m;
        const decimal PearCalories = 120m;

        private decimal totalCalories = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void BananaPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += BananaCalories;
            Result.Text = totalCalories.ToString();
        }

        private void ApplePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += AppleCalories;
            Result.Text = totalCalories.ToString();
        }

        private void OrangePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += OrangeCalories;
            Result.Text = totalCalories.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalCalories += PearCalories;
            Result.Text = totalCalories.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            totalCalories = 0m;
            Result.Text = totalCalories.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
