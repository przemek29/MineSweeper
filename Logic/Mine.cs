using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Mine
    {
        private int height;
        private int width;

        private int mine;
        private int counter = 1;

        private int[,] board;
        private int magicSign = -1;

        public int Height
        {
            get { return height; }
        }

        public int Width
        {
            get { return width; }
        }

        public int GetMine
        {
            get { return mine; }
        }

        public int AmountPlacedMines
        {
            get { return counter; }
        }
      

        public Mine(int sizeX, int sizeY, int mine)
        {
            this.height = sizeY;
            this.width = sizeX;
            this.mine = mine;
            if (height * width < mine)
                throw new System.ArgumentException("The amount of mine cannot be greater than amount of cells", "mine");
        }
/*
        public void PlaceMine(int sizeX, int sizeY, int mine)
        {
            Random rnd = new Random();
            var rndX = 0;
            var rndY = 0;
           

            for (int i = 0; counter != mine; i++)
            {
                rndX = rnd.Next(1, sizeX);
                rndY = rnd.Next(1, sizeY);

                if (board[rndX, rndY] == 0)
                {
                    board[rndX, rndY] = magicSign;

                    counter++;
                }
                else
                {
                    rndX = rnd.Next(1, sizeX);
                    rndY = rnd.Next(1, sizeY);

                    board[rndX, rndY] = magicSign;

                    counter++;
                }
            }
        }
  */
    }
}
