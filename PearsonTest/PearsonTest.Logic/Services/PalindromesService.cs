using PearsonTest.DTOs;
using PearsonTest.Logic.Interfaces.Services;
using System;
using System.Linq;

namespace PearsonTest.Logic.Services
{
    public class PalindromesService : IPalindromesService
    {
        public bool IsWordPalindrome(PalindromeInput input)
        {
            string formattedWord = StripSpacesAndPunctuation(input.Word);
            if (string.IsNullOrWhiteSpace(formattedWord)) return false;
            if (formattedWord == Reverse(formattedWord)) return true;
            return false;
        }

        private string Reverse(string word)
        {
            char[] characters = word.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }

        private string StripSpacesAndPunctuation(string input)
        {
            char[] characters = input.ToCharArray().Where(x => !Char.IsWhiteSpace(x) && !Char.IsPunctuation(x)).ToArray();
            return new string(characters).ToLower();
        }
    }
}
