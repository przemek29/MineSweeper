using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
namespace LogicTest
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void UsingFunctionPlaceMineShouldReturnStar()
        {
            var cell = new Cell(true);

            var result = cell.placeMine();

            Assert.AreEqual("*", result);
        }

        [TestMethod]
        public void UsingFunctionPlaceEmptyCellShouldReturn0()
        {
            var cell = new Cell(true);

            var result = cell.placeEmptyCell();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EmptyCellShouldReturnTrueAndMineCellShouldReturnFalse()
        {
            var cell = new Cell(true);

            cell.placeEmptyCell();
            var resultEmptyCell = cell.LogicCurrentState;

            cell.placeMine();
            var resultMineCell = cell.LogicCurrentState;

            Assert.AreEqual(true, resultEmptyCell);
            Assert.AreEqual(false, resultMineCell);

        }
    }
}
