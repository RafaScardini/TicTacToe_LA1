using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Board
    {
        public int[] Grid
        {
            get; set;
        }

        public Board()
        {
            Grid = new int[9];

            for (int i = 0; i < 9; i++)
            {
                Grid[i] = 0;
            }
        }

        public bool FullBoard()
        {
            bool isFull = true;

            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == 0)
                {
                    isFull = false;  
                }
            }
            return isFull;
        }

        public int CheckResult()
        {
            if(Grid[0] == Grid[1] && Grid[1] == Grid[2]) //1
            {
                return Grid[0];
            }
            if(Grid[3] == Grid[4] && Grid[4] == Grid[5]) //2
            {
                return Grid[3];
            }
            if (Grid[6] == Grid[7] && Grid[7] == Grid[8]) //3
            {
                return Grid[6];
            }
            if (Grid[0] == Grid[3] && Grid[3] == Grid[6]) //4
            {
                return Grid[0];
            }
            if (Grid[1] == Grid[4] && Grid[4] == Grid[7]) //5
            {
                return Grid[1];
            }
            if (Grid[2] == Grid[5] && Grid[5] == Grid[8]) //6
            {
                return Grid[2];
            }
            if (Grid[0] == Grid[4] && Grid[4] == Grid[8]) //7
            {
                return Grid[0];
            }
            if (Grid[2] == Grid[4] && Grid[4] == Grid[6]) // 8
            {
                return Grid[2];
            }
            return 0;
        }
    }
}
