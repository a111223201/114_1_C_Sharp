using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int score = int.Parse(this.textBoxScore.Text);
                string grade;
                //if (score >= 90)
                //{
                //    grade = "A";
                //}
                //else if (score >= 80) //  score 小於 90是隱含的條件
                //{
                //    grade = "B";
                //}
                //else if (score >= 70) //  score 小於 80是隱含的條件
                //{
                //    grade = "C";
                //}
                //else if (score >= 60) //  score 小於 70是隱含的條件
                //{
                //    grade = "D";
                //}
                //else
                //{
                //    grade = "F";
                //}
                if (score >=60)
                {
                    if(score >=70)
                    {
                        if(score >=80)
                        {
                            if(score >=90)
                            {
                                grade = "A";
                            }
                            else
                            {
                                grade = "B";
                            }
                        }
                        else
                        {
                            grade = "C";
                        }
                    }
                    else
                    {
                        grade = "D";
                    }
                }
                else
                {
                    grade = "F";
                }

                    this.labelGrade.Text = "成績等級:" + grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int score = int.Parse(this.textBoxScore.Text);
            }
        }
    }
}

