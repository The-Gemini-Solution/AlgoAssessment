using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGS.Challenge
{
  /*
      Devise a function that takes a string & returns the number of 
      vowels (aeiou) in that string.

      "Hi there!" = 3
      "What do you mean?"  = 6

      There are accompanying unit tests for this exercise, ensure all tests pass & make
      sure the unit tests are correct too.
   */
  public class VowelCount
  {
    private static readonly List<string> listOfVowels = new List<string>() { "a", "e", "i", "o", "u" };

    public int Count(string value)
    {
      int totalVowels = 0;
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("A value with index count of greater than 0 is required");
      }
      else
      {
        for (var x = 0; x <= value.Length - 1; x++)
        {
          string indexValue = value.ToLower()[x].ToString();
          if (listOfVowels.Any(v => v.Equals(indexValue)))
          {
            totalVowels++;
          }
        }
      }

      return totalVowels;
    }
  }
}
