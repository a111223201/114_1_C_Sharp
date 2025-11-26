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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        private int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            saveFile.InitialDirectory = @"C:\Users\m303\Desktop";


            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFile.FileName);
                outputFile.WriteLine(count + ":" + nameTextBox.Text);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
