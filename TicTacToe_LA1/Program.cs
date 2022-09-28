using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_LA1
{
    static class Program
    {
        static Board game = new Board();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int PlayerTurn = -1;
            int Player2 = -1;
            Random rand = new Random();

        
            while (game.CheckResult() == 0)
            {
                while (PlayerTurn == -1 || game.Grid[PlayerTurn] != 0)
                {
                    Console.WriteLine("Please enter a number");
                    PlayerTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine(" you entered " + PlayerTurn);
                }

                game.Grid[PlayerTurn] = 1;

                while (Player2 == -1 || game.Grid[Player2] != 0)
                {
                    Player2 = rand.Next(9); //pick random numbers between 0 and 8  
                    Console.WriteLine("Player 2 chooses " + Player2);
                }
                game.Grid[Player2] = 2;
  
            }
            //updateBoard();
            Console.WriteLine("Player " + game.CheckResult() + " Won!");
        }

        private static void updateBoard()
            {
                // assigning X and 0 on the board
                for (int i = 0; i < game.Grid.Length; i++)
                {
                    if (game.Grid[i] == 0)
                    {
                    Console.Write(" ");
                       // buttons[i].Text = "";
                    }
                    else if (game.Grid[i] == 1)
                    {
                    Console.Write("X");
                        //buttons[i].Text = "X";
                    }
                else
                {
                    Console.Write("0");
                }

                }
            }
    }
}
