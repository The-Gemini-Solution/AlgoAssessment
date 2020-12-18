using System;
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
      var result = false;
      if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
      {
        throw new ArgumentException("One of the input strings are empty. Please enter a value string");
      }
      else
      {
        var word1Formatted = Regex.Replace(word1, @"[\W_-[\s]]+", string.Empty).Replace(" ", string.Empty);
        var word2Formatted = Regex.Replace(word2, @"[\W_-[\s]]+", string.Empty).Replace(" ", string.Empty);

        // Convert to Array and all lower case letters
        char[] word1Array = word1Formatted.ToLower().ToCharArray();
        char[] word2Array = word2Formatted.ToLower().ToCharArray();

        // sort the array of letters
        Array.Sort(word1Array);
        Array.Sort(word2Array);

        var string1 = new string(word1Array);
        var string2 = new string(word2Array);

        // Compare the two words as they should now match
        if (string1.Equals(string2))
        {
          result = true;
        }
      }

      return result;
    }
  }
}
