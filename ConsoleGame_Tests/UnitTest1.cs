using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming_ConsoleGame;

namespace ConsoleGame_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(200, false)]
        [DataRow(1500, true)]
        public void LevelUpMethod_ShouldReturn(int xp, bool expectedResult)
        {
            Player player = new Player();
            player.XP = xp;

            player.LevelUp();

            Assert.AreEqual(expectedResult, player.TotalLevel == 2);
        }
    }
}
