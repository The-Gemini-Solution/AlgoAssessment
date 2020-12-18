using System;

namespace TGS.Challenge
{
  /*
      Devise a function that takes an input 'n' (integer) and returns a string that is the
      decimal representation of that number grouped by commas after every 3 digits. 

      NOTES: You cannot use any built-in formatting functions to complete this task.

      Assume: 0 <= n < 1000000000

      1 -> "1"
      10 -> "10"
      100 -> "100"
      1000 -> "1,000"
      10000 -> "10,000"
      100000 -> "100,000"
      1000000 -> "1,000,000"
      35235235 -> "35,235,235"

      There are accompanying unit tests for this exercise, ensure all tests pass & make
      sure the unit tests are correct too.
   */
  public class FormatNumber
  {
    private static readonly int smallestAllowedValue = 0;
    private static readonly int largestAllowedValue = 1000000000;
    public string Format(int value)
    {
      string result = value.ToString();
      if (value < smallestAllowedValue || value > largestAllowedValue)
      {
        throw new ArgumentOutOfRangeException();
      }
      else if (result.Length > 3)
      {
        var maxIndex = result.Length;
        var commasToAdd = (result.Length / 3);
        var loopCounter = 0;
        while (commasToAdd >= 0)
        {
          loopCounter += 1;
          var commaPlacement = 3 * loopCounter;

          if ((maxIndex - commaPlacement) > 0)
          {
            var x = result[maxIndex - commaPlacement].ToString();
            result = result.Substring(0, maxIndex - commaPlacement)
               + $",{x}"
               + result.Substring(maxIndex - commaPlacement + 1);
          }
          commasToAdd -= 1;
        }

        return result;
      }
      return result;
    }
  }
}
