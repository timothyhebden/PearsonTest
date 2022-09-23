using Microsoft.VisualStudio.TestTools.UnitTesting;
using PearsonTest.DTOs;
using PearsonTest.Logic.Services;

namespace PearsonTest.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void IsWordPalindrome_ComplexString_ReturnsTrue()
        {
            //arrange
            PalindromeInput testInput = new PalindromeInput
            {
                Word = "A man, a plan, a canal, Panama!"
            };
            PalindromesService palindromeService = new PalindromesService();

            //act
            bool isPalindrome = palindromeService.IsWordPalindrome(testInput);

            //assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsWordPalindrome_SingleWord_ReturnsFalse()
        {
            //arrange
            PalindromeInput testInput = new PalindromeInput
            {
                Word = "Computer"
            };
            PalindromesService palindromeService = new PalindromesService();

            //act
            bool isPalindrome = palindromeService.IsWordPalindrome(testInput);

            //assert
            Assert.IsFalse(isPalindrome);
        }
    }
}
