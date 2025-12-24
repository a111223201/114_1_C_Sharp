using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        int computerwin = 0;
        int playerwin = 0;
        int computerstatus = 999;
        int playerstatus = 999;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerstatus = 0;
            playerPictureBox.Image = Properties.Resources.stone_player;
            computerstatus = getcomputerchoice();
            showWinner();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerstatus = 1;
            playerPictureBox.Image = Properties.Resources.scissor_player;
            computerstatus = getcomputerchoice();
            showWinner();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerstatus = 2;
            playerPictureBox.Image = Properties.Resources.paper_player;
            computerstatus = getcomputerchoice();
            showWinner();
        }

        private int getcomputerchoice()
        {
            Random rand = new Random();
            int choice = rand.Next(3);
            switch (choice)
            {
                case 0:
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case 1:
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
                case 2:
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
            }
            return choice;
        }

        private void showWinner()
        { 
            if (playerstatus == computerstatus)
            {
                resultLabel.Text = "平手";
            }
            else if ((playerstatus == 0 && computerstatus == 1) ||
                     (playerstatus == 1 && computerstatus == 2) ||
                     (playerstatus == 2 && computerstatus == 0))
            {
                playerwin++;
                resultLabel.Text = "玩家獲勝";
            }
            else
            {
                computerwin++;
                resultLabel.Text = "電腦獲勝";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"最終比分\n玩家：{playerwin} 電腦：{computerwin}", "遊戲結束");
        }
    }
}
