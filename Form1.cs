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

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button tic = (Button)sender;
            if (player == true)
                tic.Text = "X";
            else
                tic.Text = "O";

            player = !player;
            tic.Enabled = false;


            }
        }
    }
