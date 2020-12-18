using System;
using Xunit;

namespace TGS.Challenge.Tests
{
  public class FormatNumberTests
  {
    private readonly FormatNumber _formatNumber;
    public FormatNumberTests()
    {
      this._formatNumber = new FormatNumber();
    }

    [Fact]
    public void NegativeNumber_Throws_ArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => _formatNumber.Format(-1));
    }

    [Fact]
    public void BiggerThanMaxNumber_Throws_ArgumentOutOfRangeException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => _formatNumber.Format(1000000001));
    }

    [Fact]
    public void Value_1_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(1);

      Assert.Equal("1", formatted);
    }

    [Fact]
    public void IncorrectValue_10_NotEqual_Result()
    {
      var formatted = _formatNumber.Format(1);

      // Assert.Equal("10", formatted);
      // Incorrect value entered
      // Result should be NotEqual
      // Test added for value of 10 test
      Assert.NotEqual("10", formatted);
    }

    [Fact]
    public void Value_10_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(10);

      Assert.Equal("10", formatted);
    }

    [Fact]
    public void Value_100_Incorrect_ExpectedValue()
    {
      var formatted = _formatNumber.Format(100);

      Assert.NotEqual("1,00", formatted);
    }

    [Fact]
    public void Value_100_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(100);

      Assert.Equal("100", formatted);
    }

    [Fact]
    public void Value_1000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(1000);

      Assert.Equal("1,000", formatted);
    }

    [Fact]
    public void Value_10000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(10000);

      Assert.Equal("10,000", formatted);
    }

    [Fact]
    public void Value_100000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(100000);

      Assert.Equal("100,000", formatted);
    }
    
    [Fact]
    public void Value_1000000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(1000000);

      Assert.Equal("1,000,000", formatted);
    }

    [Fact]
    public void Value_35235235_Expected_Incorrect_Result()
    {
      var formatted = _formatNumber.Format(35235235);

      Assert.NotEqual("35,2352,35", formatted);
    }

    [Fact]
    public void Value_35235235_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(35235235);

      Assert.Equal("35,235,235", formatted);
    }
  }  
}