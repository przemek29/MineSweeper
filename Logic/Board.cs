using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Board
    {
        private int countMines;
        private int height;
        private int width;
        private int mines;
        private Cell[,] cellTable;

        public int Height
        {
            get { return cellTable.GetLength(0); }
        }

        public int Width
        {
            get {return cellTable.GetLength(1); } 
        }

        public int GetPlacedMines
        {
            get { return countMines; }
        }
        
        public Board(int sizeX, int sizeY, int amountMines)
        {
            Initialization(sizeX, sizeY, amountMines);
        }

        private void Initialization(int sizeX, int sizeY, int amountMines)
        {
            this.height = sizeY;
            this.width = sizeX;
            this.mines = amountMines;

            if (height == 0 || width == 0)
                throw new System.ArgumentException("Size of dimensions of board should be different than \"0\"", "height, width");

            if (width * height <= mines)
                throw new System.ArgumentException("Amount of mines should be lower than the numbers of cells", "mines");

            this.cellTable = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cellTable[i, j] = new Cell();
                    cellTable[i, j].placeEmptyCell();
                }
            }

        }

        public void placeMines()
        {
            Random rnd = new Random();
            var rndX = 0;
            var rndY = 0;
            
            for (int i = 0; countMines != mines; i++)
            {
                rndX = rnd.Next(0, width - 1);
                rndY = rnd.Next(0, height - 1);


                if (cellTable[rndX, rndY].CurrentState == false)
                {
                    cellTable[rndX, rndY].placeMine();
                    countMines++;
                }
            }

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if (cellTable[i, j].CurrentState == false)
                        cellTable[i, j].EmptyCellState = CountNeighbours(i, j);
                }
            }
        }

        private bool checkMine(int x, int y)
        {
            if (cellTable[x, y].CurrentState == true)
                return true;
            return false;
        }

        private bool SafeGetCurrentState(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < height && y < width)
            {
                return cellTable[x, y].CurrentState;
            }
            return false;
        }

        public int CountNeighbours(int x, int y)
        {
            int n = 0;

            if (SafeGetCurrentState(x - 1, y - 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x - 1, y))
            {
                n++;
            }

            if (SafeGetCurrentState(x, y - 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x + 1, y))
            {
                n++;
            }

            if (SafeGetCurrentState(x, y + 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x + 1, y + 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x - 1, y + 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x + 1, y - 1))
            {
                n++;
            }

            return n;
        }

        private void ProcessSingleCell(int x, int y)
        {
            int neighbours = CountNeighbours(x, y);

            cellTable[x, y].EmptyCellState = neighbours;
        }
    }
}
