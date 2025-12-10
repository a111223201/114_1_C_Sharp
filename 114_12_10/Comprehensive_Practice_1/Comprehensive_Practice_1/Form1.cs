using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprehensive_Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowMax_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            int quiz1, quiz2, quiz3;
            if(int.TryParse(txtScore1.Text, out quiz1) &&
               int.TryParse(txtScore2.Text, out quiz2) &&
               int.TryParse(txtScore3.Text, out quiz3))
            {
               showResult(lastName, firstName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("請輸入有效的分數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }
        }

        private void clearTextBoxes()
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            txtScore1.Focus();
        }

        private void showResult(string lastName, string firstName, int quiz1, int quiz2, int quiz3)
        {
            int highestscore = 0;

            findHighstScore(quiz1, quiz2, quiz3, ref highestscore);

            
            lblResult.Text = $"{lastName}{firstName}的最高分是 {highestscore} 分";
        }

        private void findHighstScore(int quiz1, int quiz2, int quiz3, ref int highestscore)
        {
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestscore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestscore = quiz2;
            }
            else
            {
                highestscore = quiz3;
            }
        }
    }
}
