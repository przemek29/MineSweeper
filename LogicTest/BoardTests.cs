using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logic;

namespace LogicTest
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Width and Height of board should be greater than \"0\" ")]
        public void CheckSizeOfEmptyBoard()
        {
            var board = new Board(0, 0, 0);
            var width = board.Width;
            var height = board.Height;


            Assert.AreEqual(0, width);
            Assert.AreEqual(0, height);
        }

        [TestMethod]
        public void CheckSizeOfQuadraticBoard()
        {
            var board = new Board(4, 4, 0);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(4, width);
            Assert.AreEqual(4, height);
        }

        [TestMethod]
        public void CheckSizeOfUnsymetricalBoard()
        {
            var board = new Board(6, 7, 0);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(6, height);
            Assert.AreEqual(7, width);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Amount of mines should be lower than the numbers of cells")]
        public void ToHighAmountOfMinesRelativeToSizeBoardShouldReturnExceptions()
        {
            var board = new Board(10, 10, 101);

            var width = board.Width;
            var height = board.Height;

            Assert.AreEqual(6, height);
            Assert.AreEqual(7, width);
        }

        [TestMethod]
        public void CheckAmountOfPlacedMines()
        {
            var board = new Board(3, 3, 3);

            board.placeMines();

            Assert.AreEqual(3, board.GetPlacedMines);
        }
    }
}
