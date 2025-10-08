using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 計算平均按鈕事件
        // 當使用者按下「計算平均」按鈕時，會執行此方法
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3, average;
            try
            {
                // 嘗試將輸入的成績轉換為數字
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                // 計算三個成績的平均值
                average = (test1 + test2 + test3) / 3;
                // 將平均成績顯示在標籤上，格式化為兩位小數
                averageLabel.Text = average.ToString("n2");
            }
            catch(Exception ex)  
            {
                MessageBox.Show("請輸入有效的數字成績。", ex.Message);
                // 清空三個成績輸入框
                test1TextBox.Clear();
                test2TextBox.Clear();
                test3TextBox.Clear();
                // 清空平均成績顯示欄位
                averageLabel.Text = string.Empty;
                // 將游標移到第一個成績輸入框
                test1TextBox.Focus();
            }
           
        }

        // 清除按鈕事件
        // 當使用者按下「清除」按鈕時，會執行此方法
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空三個成績輸入框
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            // 清空平均成績顯示欄位
            averageLabel.Text = string.Empty;
            // 將游標移到第一個成績輸入框
            test1TextBox.Focus();
        }

        // 離開按鈕事件
        // 當使用者按下「離開」按鈕時，會執行此方法
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
