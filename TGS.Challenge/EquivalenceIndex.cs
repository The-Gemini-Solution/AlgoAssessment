using System.Diagnostics.CodeAnalysis;

namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
         int n = numbers.Length;

         int[] prefixSum1 = new int[n];
         prefixSum1[0] = numbers[0];
         // Forming prefix sum
         // array from 0
         int[] prefixSum = new int[n];
         prefixSum[0] = numbers[0];
         for (int i = 1; i < n; i++)
            prefixSum[i] = prefixSum[i - 1] +
                           numbers[i];

         // Forming suffix sum
         // array from n-1
         int[] suffixSum = new int[n];
         suffixSum[n - 1] = numbers[n - 1];
         for (int i = n - 2; i >= 0; i--)
            suffixSum[i] = suffixSum[i + 1] +
                           numbers[i];

         // Find the point where prefix
         // and suffix sums are same.
         for (int i = 1; i < n - 1; i++)
            if (prefixSum[i] == suffixSum[i])
               return numbers[i];

         return -1;
      }
    }
}
