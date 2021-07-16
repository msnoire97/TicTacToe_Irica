﻿using System;
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

        public Color Turquoise { get; private set; }

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
            {
                winner = true;
                A1.BackColor = Color.Teal;
                A2.BackColor = Color.Teal;
                A3.BackColor = Color.Teal;
            }
                
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
            {
                winner = true;
                B1.BackColor = Color.Teal;
                B2.BackColor = Color.Teal;
                B3.BackColor = Color.Teal;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
            {
                winner = true;
                C1.BackColor = Color.Teal;
                C2.BackColor = Color.Teal;
                C3.BackColor = Color.Teal;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
            {
                winner = true;
                A1.BackColor = Color.Teal;
                B1.BackColor = Color.Teal;
                C1.BackColor = Color.Teal;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
            {
                winner = true;
                A2.BackColor = Color.Teal;
                B2.BackColor = Color.Teal;
                C2.BackColor = Color.Teal;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
            {
                winner = true;
                A3.BackColor = Color.Teal;
                B3.BackColor = Color.Teal;
                C3.BackColor = Color.Teal;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
            {
                winner = true;
                A1.BackColor = Color.Teal;
                B2.BackColor = Color.Teal;
                C3.BackColor = Color.Teal;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != ""))
            {
                winner = true;
                C1.BackColor = Color.Teal;
                B2.BackColor = Color.Teal;
                A3.BackColor = Color.Teal;
            }
            if (winner == true)
            {
                String winner = "";
                if (player == true)
                    winner = "O";
                else
                    winner = "X";

                Disable_Tics();
                MessageBox.Show(winner + " has won this round!", "Hoorah!");
            }
        }

        private void Draw_Check()
        {
            if (turns == 9)
                MessageBox.Show("This game ends in a draw!", "Draw!");
        }

        private void Disable_Tics()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void New_Game(object sender, EventArgs e)
        {
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
            A1.Enabled = true; A2.Enabled = true; A3.Enabled = true; B1.Enabled = true; B2.Enabled = true; B3.Enabled = true; C1.Enabled = true; C2.Enabled = true; C3.Enabled = true;
            bool player = true;
            bool winner = false;
            int turns = 0;
        }
    }
}
