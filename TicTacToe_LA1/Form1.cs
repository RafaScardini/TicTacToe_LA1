using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_LA1
{
   
    public partial class Form1 : Form
    {
        Board game = new Board();
        Button[] buttons = new Button[9];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
           game = new Board();

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            for (int i = 0; i < buttons.Length; i++) //click event
            {
                buttons[i].Click += PlayerClick;
                buttons[i].Tag = i;                 // adding a Tag - property of a button that can add any kind of data
            }
        }

        private void PlayerClick(object sender, EventArgs e) //Method
        {
           // test if the click event of the buttons is working
            Button clickedButton = (Button)sender;          //casting to a button
            MessageBox.Show("button " + clickedButton.Tag + " was clicked");

            int gamesNumber = (int)clickedButton.Tag;
            game.Grid[gamesNumber] = 1;
            updateBoard();

            secondPlayer();

        }

        private void secondPlayer()
        {
            //Generate random number for player 2
            int Player2 = rand.Next(9);
            while (Player2 == -1 || game.Grid[Player2] != 0)
            {
                Player2 = rand.Next(9); //pick random numbers between 0 and 8  
                Console.WriteLine("Player 2 chooses " + Player2);
            }
            game.Grid[Player2] = 2;
            updateBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }

        private void updateBoard()
        {
            // assigning X and 0 on the board
            for (int i = 0; i < game.Grid.Length; i++)
            {
                
                if (game.Grid[i] == 0)
                {
                    
                    buttons[i].Text = "";
                }
                else if (game.Grid[i] == 1)
                {
                    buttons[i].Text = "X";
                }
                else if (game.Grid[i] == 2)
                {
                    buttons[i].Text = "0";
                }
               
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
