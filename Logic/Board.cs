using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Board
    {
        public int Height
        {
            get { return board.GetLength(0); }
        }

        public int Width
        {
            get {return board.GetLength(1); } 
        }

        private int[,] board;

        public Board(int [,] inputBoard)
        {
            this.board = inputBoard;
        }

        public int GetCell(int x, int y)
        {
            return board[x, y];
        }
    }
}
