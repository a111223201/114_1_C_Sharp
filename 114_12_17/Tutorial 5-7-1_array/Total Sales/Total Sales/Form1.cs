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
            decimal[] sales = new decimal[8];
            int index = 0;

            try
            {
                inputFile = File.OpenText("Sales.txt"); // 開啟檔案
                salesListBox.Items.Clear(); // 清空清單框
                while (!inputFile.EndOfStream)    // 讀取直到檔案結尾
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        salesListBox.Items.Add(line); // 將讀取的行加入清單框
                        sales[index] = currentSales; // 累加到總銷售額
                        index++;
                    }
                    else
                    {
                        MessageBox.Show($"無法轉換為數字: {line}");
                        //break;
                    }
                }
                inputFile.Close(); // 關閉檔案
                
                for (int i = 0; i < index; i++)
                {
                    totalSales += sales[i];
                }

                totalLabel.Text = totalSales.ToString("C");
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
