/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace Logic
{
    public class Cell
    {
        private bool logicCurrentState;

        public bool LogicCurrentState
        {
            get { return logicCurrentState; }
            set { logicCurrentState = value; }
        }

        public Cell(bool state)
        {
            this.logicCurrentState = state;
        }
        public string placeMine()
        {
            LogicCurrentState = false;
            return "*";
        }

        public int placeEmptyCell()
        {
            LogicCurrentState = true;
            return 0;
        }

    }
}
