using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Irica
{
    public partial class Form1 : Form
    {
        bool player = true;
        bool winner = false;
        int turns = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button tic = (Button)sender;
            if (tic.Text == "")
            {
                if (player == true)
                    tic.Text = "X";
                else
                    tic.Text = "O";

                player = !player;
                turns++;

                Winner_Check();
                Draw_Check();
            } 
        }

        private void Winner_Check ()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != ""))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
                winner = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
                winner = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != ""))
                winner = true;

            if (winner == true)
            {
                String winner = "";
                if (player == true)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " has won this round!", "Hoorah!");
            }
        }

        private void Draw_Check()
        {
            if (turns == 9)
                MessageBox.Show("This game ends in a draw!", "Draw!");
        }
    }
}
