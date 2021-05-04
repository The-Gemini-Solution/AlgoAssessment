using System;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            IsValidStringInput(word1);
            IsValidStringInput(word2);

            var preparedWord1 = PrepareString(word1);
            var preparedWord2 = PrepareString(word2);

            var reversedString = ReverseString(preparedWord1);

            return reversedString == preparedWord2;
        }

        private void IsValidStringInput(string word)
        {
            if (word == null || word == "")
            {
                throw new ArgumentException("Enter a valid form of input.");
            }
        }

        private string PrepareString(string word)
        {
            char[] listOfCharToRemove = { '.', ' ' };

            var preparedWord = word.Trim(listOfCharToRemove);

            return preparedWord;
        }

        private string ReverseString(string word)
        {
            char[] array = word.ToCharArray();
            Array.Reverse(array);

            return new string(array);
        }
    }
}
