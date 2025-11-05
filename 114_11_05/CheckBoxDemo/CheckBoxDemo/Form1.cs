using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "";

            if (checkBox1.Checked)
            {
                message += "夏威夷 ";
            }
            else if (checkBox2.Checked)
            {
                message += "章魚燒 ";
            }
            else if (checkBox3.Checked)
            {
                message += "綜合海鮮 ";
            }
            else if (checkBox4.Checked)
            {
                message += "義式火腿 ";
            }
            else
            {
                message = "請選擇披薩口味 ";
            }
            MessageBox.Show(message);
        }
    }
}
