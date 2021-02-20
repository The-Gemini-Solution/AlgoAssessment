using System;
using System.Linq;
using System.Text.RegularExpressions;

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
            //Guard clause against string.Empty || nulls || just whitespace
            if (string.IsNullOrWhiteSpace(word1) || string.IsNullOrWhiteSpace(word2))
                throw new ArgumentException();

            var word1Array = word1
                .RemoveSpecialChars()
                .ToLowerInvariant()
                .ToCharArray();

            var word2Array = word2
                .RemoveSpecialChars()
                .ToLowerInvariant()
                .ToCharArray();

            //First wrote this out as a basic for and an if else condition
            // After tests passed i then converted to linq using Resharper
            return word1Array.All(t => word2Array.Contains(t));
        }
    }

    public static class StingExtentions
    {
        public static string RemoveSpecialChars(this string s)
            => Regex.Replace(s, "[^0-9a-zA-Z]+", "");
    }
}
