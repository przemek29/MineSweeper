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
            var board = new Board(new int[0, 0]);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(0, width);
            Assert.AreEqual(0, height);
        }

        [TestMethod]
        public void CheckSizeOfQuadraticBoard()
        {
            var board = new Board(new int[4, 4]);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(4, width);
            Assert.AreEqual(4, height);
        }

        [TestMethod]
        public void CheckSizeOfUnsymetricalBoard()
        {
            var board = new Board(new int[6, 7]);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(6, height);
            Assert.AreEqual(7, width);
        }

        [TestMethod]
        public void CheckSizeOfCompletedBoard()
        {
            var inputBoard = new int[,] { { 1, 2, 3 },{ 3, 2, 1 },{ 3, 3, 3 } };
            var board = new Board(inputBoard);

            Assert.AreEqual(1, board.GetCell(0, 0));
            Assert.AreEqual(2, board.GetCell(0, 1));
            Assert.AreEqual(3, board.GetCell(0, 2));

            Assert.AreEqual(3, board.GetCell(1, 0));
            Assert.AreEqual(2, board.GetCell(1, 1));
            Assert.AreEqual(1, board.GetCell(1, 2));

            Assert.AreEqual(3, board.GetCell(2, 0));
            Assert.AreEqual(3, board.GetCell(2, 1));
            Assert.AreEqual(3, board.GetCell(2, 2));
        }
    }
}


