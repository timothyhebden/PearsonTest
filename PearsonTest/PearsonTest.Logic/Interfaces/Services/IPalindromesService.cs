using PearsonTest.DTOs;

namespace PearsonTest.Logic.Interfaces.Services
{
    public interface IPalindromesService
    {
        bool IsWordPalindrome(PalindromeInput input);
    }
}
