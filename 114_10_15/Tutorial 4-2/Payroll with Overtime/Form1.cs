using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算薪資」按鈕時觸發的事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 這裡可以加入薪資計算的邏輯
            // 例如，讀取工時和時薪，計算總薪資，並顯示在 grossPayLabel 上
            const decimal BASE_HOURS = 40m; // 基本工時
            const decimal OVERTIME_MULTIPLIER = 1.5m; // 加班倍率

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS;
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_MULTIPLIER);
                }
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者按下「清除」按鈕時觸發的事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空工時、時薪與薪資顯示欄位
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點移回工時輸入欄位
            hoursWorkedTextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時觸發的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
