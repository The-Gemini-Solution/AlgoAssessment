using System;
using System.Collections.Generic;
using System.Linq;
namespace TGS.Challenge.Algorithms
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
            bool isAnagram = false;

            if (word2.Length == 0 || word1.Length == 0)
                throw new ArgumentException();

            var word1CharArray = word1.ToLower().ToCharArray();
            var word2CharArray = word2.ToLower().ToCharArray();
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < word1CharArray.Length; i++)
			{
                var c = word1CharArray[i];
                if(c != '_' || c != ' ')
				{
                    if (dict.ContainsKey(c))
                    {
                        int cCount;
                        dict.TryGetValue(c, out cCount);
                        cCount++;
                        dict[c] = cCount;
                        if (cCount % 2 == 0)
                        {
                            isAnagram = true;
						}
                    }
                    else
                    {
                        var matchingCharactersLen = word2CharArray.Where(a => a == c).Count();
                        if (matchingCharactersLen >= 1)
                        {
                            isAnagram = true;
                        }
                        else
                        {
                            isAnagram = false;
                            break;
                        }
                        dict.Add(c, matchingCharactersLen + 1);
                    }
                } 
                
            }

            return isAnagram;
      }
    }
}
