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
            get { return cell.GetLength(0); }
        }

        public int Width
        {
            get {return cell.GetLength(1); } 
        }

        private Cell[,] cell;

        public Board(int sizeX, int sizeY)
        {
            this.cell = new Cell[sizeX, sizeY];
           
        }

    }
}
