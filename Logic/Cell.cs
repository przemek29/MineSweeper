using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Cell
    {
        public bool CurrentState { get; private set; }
        
        public Cell()
        {
            
        }

        public string placeMine()
        {
            CurrentState = false;
            return "*";
        }

        public int placeEmptyCell()
        {
            CurrentState = true;
            return 0;
        }

    }
}
