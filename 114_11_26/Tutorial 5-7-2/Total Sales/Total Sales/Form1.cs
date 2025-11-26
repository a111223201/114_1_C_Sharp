using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile; // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 總銷售額
            decimal currentSales = 0.0m;   // 當前銷售額
            string line; // 用於讀取檔案行的變數

            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Downloads\Sales_modified_en.txt"); // 開啟檔案
                salesListBox.Items.Clear(); // 清空清單框
                while (!inputFile.EndOfStream)    // 讀取直到檔案結尾
                {
                    line = inputFile.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue; // 跳過空行

                    // 將行切割為欄位，假定最後一個欄位是數字（銷售額），前面的部分是月份或名稱
                    var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2)
                    {
                        MessageBox.Show($"格式錯誤（需要: 月份 與 數字）: {line}");
                        continue;
                    }

                    var amountToken = parts[parts.Length - 1];
                    if (decimal.TryParse(amountToken, NumberStyles.Number, CultureInfo.InvariantCulture, out currentSales) ||
                        decimal.TryParse(amountToken, NumberStyles.Number, CultureInfo.CurrentCulture, out currentSales))
                    {
                        // 使用第一個欄位作為月份顯示（可改為合併多個欄位如果月份包含空格）
                        string month = parts[0];
                        salesListBox.Items.Add($"{month} - {currentSales.ToString("c")}"); // 顯示月份與格式化金額
                        totalSales += currentSales; // 累加到總銷售額
                    }
                    else
                    {
                        MessageBox.Show($"無法轉換為數字: {amountToken}");
                    }
                }
                inputFile.Close(); // 關閉檔案
                totalLabel.Text = totalSales.ToString("c"); // 顯示總銷售額
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
