using System;
using Xunit;

namespace TGS.Challenge.Tests
{
  public class VowelCountTests
  {
    private readonly VowelCount _vowelCount;

    public VowelCountTests()
    {
      this._vowelCount = new VowelCount();
    }

    [Fact]
    public void Value_IsRequired()
    {
      Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
    }

    [Fact]
    public void AEIOU_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("AEIOU");

      //Assert.Equal(count, 6);
      // Test result adjusted to be 5, total count of chars are only 5
      // Added a new test to reflect negative outcoming with old expectation
      Assert.Equal(count, 5);
    }

    [Fact]
    public void AEIOU_Negative_Result_Expected()
    {
      var count = _vowelCount.Count("AEIOU");

      Assert.NotEqual(count, 6);
    }

    [Fact]
    public void lmnpqr_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("lmnpqr");

      Assert.Equal(count, 0);
    }

    [Fact]
    public void abcdefghijklmnopqrstuvwxyz__incorrect_result_expected()
    {
      var count = _vowelCount.Count("lmnpqr");

      // This should be NotEqual, string provided does not have vowels
      // Added test to indicate correct expectation
      Assert.NotEqual(count, 5);
    }

    [Fact]
    public void abcdefghijklmnopqrstuvwxyz_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("lmnpqr");

      Assert.Equal(count, 0);
    }

    [Fact]
    public void Howmanycanyoufind_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("How many can you find");

      Assert.Equal(count, 6);
    }
  }
}