using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 宣告常數，代表各種硬幣的金額
        const decimal FIVE_CENTS = 0.05m; // 五角
        const decimal TEN_CENTS = 0.10m; // 一角
        const decimal TWENTY_FIVE_CENTS = 0.25m; // 二十五角
        const decimal FIFTY_CENTS = 0.50m; // 五十角
        // 用來儲存總金額的欄位
        private decimal total = 0m;

        // 建構子，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 處理五角硬幣圖片點擊事件
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將五角加入總金額
            total += FIVE_CENTS;
            // 顯示目前總金額（以字串格式）
            totalLabel.Text = total.ToString();
        }

        // 處理一角硬幣圖片點擊事件
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將一角加入總金額
            total += TEN_CENTS;
            // 顯示目前總金額
            totalLabel.Text = total.ToString();
        }

        // 處理二十五角硬幣圖片點擊事件
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將二十五角加入總金額
            total += TWENTY_FIVE_CENTS;
            // 顯示目前總金額
            totalLabel.Text = total.ToString();
        }

        // 處理五十角硬幣圖片點擊事件
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將五十角加入總金額
            total += FIFTY_CENTS;
            // 顯示目前總金額
            totalLabel.Text = total.ToString();
        }

        // 處理離開按鈕點擊事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
