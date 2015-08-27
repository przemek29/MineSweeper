using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Mine
    {
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

        private int height;
        private int width;
        private int mine;
        

        public Mine(int sizeX, int sizeY, int mine)
        {
            this.height = sizeY;
            this.width = sizeX;
            this.mine = mine;  
            if (height * width < mine)
                throw new System.ArgumentException("The amount of mine cannot be greater than amount of cells", "mine");
        }

        
    }
}
