using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class Form1 : Form
    {
        int playerTurn = 0;
        int turnNumber = 0;
        string playerCharacter = " ";
        int b1State = 0;
        int b2State = 0;
        int b3State = 0;
        int b4State = 0;
        int b5State = 0;
        int b6State = 0;
        int b7State = 0;
        int b8State = 0;
        int b9State = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b1State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b1State = 2;
            }
            turnNumber++;
            button1.Text = playerCharacter;
            button1.Enabled = false;
            button1.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b2State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b2State = 2;
            }
            turnNumber++;
            button2.Text = playerCharacter;
            button2.Enabled = false;
            button2.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b3State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b3State = 2;
            }
            turnNumber++;
            button3.Text = playerCharacter;
            button3.Enabled = false;
            button3.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b4State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b4State = 2;
            }
            turnNumber++;
            button4.Text = playerCharacter;
            button4.Enabled = false;
            button4.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b5State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b5State = 2;
            }
            turnNumber++;
            button5.Text = playerCharacter;
            button5.Enabled = false;
            button5.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b6State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b6State = 2;
            }
            turnNumber++;
            button6.Text = playerCharacter;
            button6.Enabled = false;
            button6.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b7State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b7State = 2;
            }
            turnNumber++;
            button7.Text = playerCharacter;
            button7.Enabled = false;
            button7.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b8State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b8State = 2;
            }
            turnNumber++;
            button8.Text = playerCharacter;
            button8.Enabled = false;
            button8.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (playerTurn == 0)
            {
                playerCharacter = "X";
                playerTurn = 1;
                b9State = 1;
            }
            else
            {
                playerCharacter = "O";
                playerTurn = 0;
                b9State = 2;
            }
            turnNumber++;
            button9.Text = playerCharacter;
            button9.Enabled = false;
            button9.BackColor = Color.DarkGray;

            if (turnNumber >= 5)
            {
                checkWinner();
            }
        }
        void checkWinner()
        {
            if (turnNumber % 2 == 1)
            {
                if (b1State == 1 && b2State == 1 && b3State == 1) { gameEnd(); }
                else if (b4State == 1 && b5State == 1 && b6State == 1) {gameEnd(); }
                else if (b7State == 1 && b8State == 1 && b9State == 1) {gameEnd(); }
                else if (b1State == 1 && b4State == 1 && b7State == 1) {gameEnd(); }
                else if (b2State == 1 && b5State == 1 && b8State == 1) {gameEnd(); }
                else if (b3State == 1 && b6State == 1 && b9State == 1) {gameEnd(); }
                else if (b1State == 1 && b5State == 1 && b9State == 1) {gameEnd(); }
                else if (b3State == 1 && b5State == 1 && b7State == 1) {gameEnd(); }
                else
                {
                    if (turnNumber == 9)
                    {
                        MessageBox.Show("Cat's Game");
                        this.Close();
                    }
                }
            }
            else {
                if (b1State == 2 && b2State == 2 && b3State == 2) {gameEnd(); }
                else if (b4State == 2 && b5State == 2 && b6State == 2) {gameEnd(); }
                else if (b7State == 2 && b8State == 2 && b9State == 2) {gameEnd(); }
                else if (b1State == 2 && b4State == 2 && b7State == 2) {gameEnd(); }
                else if (b2State == 2 && b5State == 2 && b8State == 2) {gameEnd(); }
                else if (b3State == 2 && b6State == 2 && b9State == 2) {gameEnd(); }
                else if (b1State == 2 && b5State == 2 && b9State == 2) {gameEnd(); }
                else if (b3State == 2 && b5State == 2 && b7State == 2) {gameEnd(); }
            }
            
        }
        void gameEnd()
        {
            MessageBox.Show("Player " + playerTurn.ToString() + " Won");
            this.Close();
        }
    }
}
