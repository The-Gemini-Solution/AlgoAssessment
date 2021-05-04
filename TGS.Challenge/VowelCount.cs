using System;

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
            IsValidString(value);

            var result = CountForVowels(value);

            return result;
        }

        private void IsValidString(string value)
        {
            if(value == null || value == "")
            {
                throw new ArgumentException("Ensure that a proper input was given, an empty string or null value will not be accepted.");
            }
        }

        private int CountForVowels(string value)
        {
            var counter = 0;
            char[] listOfChar = value.ToCharArray();

            foreach(var item in listOfChar)
            {
                if(item == 'a' || item == 'A')
                {
                    counter++;
                }
                if (item == 'e' || item == 'E')
                {
                    counter++;
                }
                if (item == 'i' || item == 'I')
                {
                    counter++;
                }
                if (item == 'o' || item == 'O')
                {
                    counter++;
                }
                if (item == 'u' || item == 'U')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
