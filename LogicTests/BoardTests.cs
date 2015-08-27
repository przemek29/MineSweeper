using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    
    [TestClass]
    public class BoardTests
    {
        
        [TestMethod]
        public void CheckSizeOfEmptyBoard()
        {
            var board = new Board(0, 0);
            var width = board.Width;
            var height = board.Height;

            
            Assert.AreEqual(0, width);
            Assert.AreEqual(0, height);
        }

        [TestMethod]
        public void CheckSizeOfQuadraticBoard()
        {
            var board = new Board(4, 4);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(4, width);
            Assert.AreEqual(4, height);
        }

        [TestMethod]
        public void CheckSizeOfUnsymetricalBoard()
        {
            var board = new Board(6, 7);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(6, height);
            Assert.AreEqual(7, width);
        }
    }
}


