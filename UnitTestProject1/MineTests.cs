using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    [TestClass]
    public class MineTests
    {
        [TestMethod]
        public void CheckAmountOfMine()
        {

            var mine = new Mine(10, 10, 4);


            Assert.AreEqual(4, mine.GetMine);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A userId of null was inappropriately allowed.")]
        public void TheAmountOfMineShouldBeBelowOfAmountCellBoard()
        {
            var mine = new Mine(10, 10, 101);
            
        }

    }
}