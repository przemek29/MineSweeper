using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Logic
{
    public class Game
    {
        private bool gameOver;
        private int width;
        private int height;
        private int mines;

        public void startGame(int selection)
        {
            
            switch (selection)
            {
                case 1:
                    width = 9;
                    height = 9;
                    mines = 10;

                    break;

                case 2:
                    width = 16;
                    height = 16;
                    mines = 40;

                    break;

                case 3:
                    width = 30;
                    height = 16;
                    mines = 99;

                    break;
            }
        }

        public void startGame(int width, int height, int mines)
        {
            
            this.width = width;
            this.height = height;
            this.mines = mines;

        }

    }

}

