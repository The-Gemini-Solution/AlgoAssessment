using System;
using System.Collections.Generic;

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
        public int Count(string value)
        {
            int vowelCounter = 0;

            if (!string.IsNullOrEmpty(value) )
            {
               var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
               foreach (char c in value.ToLower())
               {
                  if (vowels.Contains(c))
                  {
                     vowelCounter++;
                  }
               }
            }
            return vowelCounter;
        }
    }
}
