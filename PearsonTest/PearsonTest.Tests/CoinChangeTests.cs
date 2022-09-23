using Microsoft.VisualStudio.TestTools.UnitTesting;
using PearsonTest.Logic.Services;

namespace PearsonTest.Tests
{
    [TestClass]
    public class CoinChangeTests
    {
        [TestMethod]
        public void HowManyCoinsAreNeeded_Change39_Returns5()
        {
            //arrange
            int changeValue = 39;

            CoinChangeService coinChangeService = new CoinChangeService();

            //act
            int coinQuantity = coinChangeService.HowManyCoinsAreNeeded(changeValue);

            //assert
            Assert.AreEqual(5, coinQuantity);
        }

        [TestMethod]
        public void HowManyCoinsAreNeeded_Change169_Returns6()
        {
            //arrange
            int changeValue = 169;

            CoinChangeService coinChangeService = new CoinChangeService();

            //act
            int coinQuantity = coinChangeService.HowManyCoinsAreNeeded(changeValue);

            //assert
            Assert.AreEqual(6, coinQuantity);
        }
    }
}
