using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eightofDiamonds_Click(object sender, EventArgs e)
        {
            showLabel.Text = "8 of Diamonds";
        }

        private void twoofClubs_Click(object sender, EventArgs e)
        {
            showLabel.Text = "2 of Clubs";
        }

        private void kingofSpades_Click(object sender, EventArgs e)
        {
            showLabel.Text = "King of Spades";
        }

        private void aceofSpades_Click(object sender, EventArgs e)
        {
            showLabel.Text = "Ace of Spades";
        }

        private void jokerofBlack_Click(object sender, EventArgs e)
        {
            showLabel.Text = "Black Joker";
        }
    }
}
