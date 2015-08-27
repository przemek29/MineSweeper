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
            var cell = new Cell();

            var result = cell.placeMine();

            Assert.AreEqual("*", result);
        }

        [TestMethod]
        public void UsingFunctionPlaceEmptyCellShouldReturn0()
        {
            var cell = new Cell();

            var result = cell.placeEmptyCell();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EmptyCellShouldReturnTrueAndMineCellShouldReturnFalse()
        {
            var cell = new Cell();

            cell.placeEmptyCell();
            var resultEmptyCell = cell.CurrentState;

            cell.placeMine();
            var resultMineCell = cell.CurrentState;

            Assert.AreEqual(true, resultEmptyCell);
            Assert.AreEqual(false, resultMineCell);

        }
    }
}
