using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "點餐內容: ";
            String drink = "";
            String sandwich = "";
            // 飲料部分
            if (CoffeeradioButton.Checked)
            {
                drink = "咖啡 ";
            }
            else if(MilkTearadioButton.Checked)
            {
                drink = "奶茶 ";
            }
            else if(JuiceradioButton.Checked)
            {
                drink = "果汁 ";
            }
            else if(BlackTearadioButton.Checked)
            {
                drink = "紅茶 ";
            }
            else
            {
                drink = "";
            }
            // 三明治部分
            if (JamSandradioButton.Checked)
            {
                sandwich = "果醬三明治 ";
            }
            else if(HamSandradioButton.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else if(tunaSandradioButton.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else
            {
                sandwich = "";
            }

            message += drink + sandwich;
            MessageBox.Show(message);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
