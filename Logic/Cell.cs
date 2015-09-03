using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Cell
    {
        private bool logicState; 
        private string mineState;
        private int emptyCellState;

        public string MineState
        {
            get { return mineState; }
            set { mineState = value; }
        }

        public int EmptyCellState
        {
            get { return emptyCellState; }
            set { emptyCellState = value; }
        }

        public bool CurrentState
        {
            get { return logicState; }
            set { logicState = value; }
        }

        public void placeMine()
        {
            logicState = true;
            mineState = "*";
        }

        public void placeEmptyCell()
        {
            logicState = false;
            emptyCellState = 0;
        }

    }
}
