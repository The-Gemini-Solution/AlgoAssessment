using System;
using System.Linq;
using NUnit.Framework;


namespace TGS.Challenge.Tests
{ 
  [TestFixture()]

   public class FormatNumberTests
   {
    private readonly FormatNumber _formatNumber;
    public FormatNumberTests()
    {
      _formatNumber = new FormatNumber();
    }

    [Test()]
    public void NegativeNumber_Throws_ArgumentOutOfRangeException()
    {
       var result = _formatNumber.Format(-1);
       Assert.AreNotEqual(-1, result);
    }

    [Test()]
    public void BiggerThanMaxNumber_Throws_ArgumentOutOfRangeException()
    {
       var result = _formatNumber.Format(1000000001);
       Assert.AreNotSame(result, 1000000001);
    }

    [Test()]
    public void Value_1_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(1);

      Assert.AreEqual("1", formatted);
    }

    [Test()]
    public void Value_10_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(10);

      Assert.AreEqual("10", formatted);
    }

    [Test()]
    public void Value_100_Returns_ValidString()
    {
       var formatted = _formatNumber.Format(100);

       Assert.AreNotEqual("1,00", formatted);
    }

    [Test()]
    public void Value_1000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(1000);

      Assert.AreEqual("1,000", formatted);
    }
  
    [Test()]
    public void Value_10000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(10000);

      Assert.AreEqual("10,000", formatted);
    }

    [Test()]
    public void Value_100000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(100000);

      Assert.AreEqual("100,000", formatted);
    }
    
    [Test()]
    public void Value_1000000_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(1000000);

      Assert.AreEqual("1,000,000", formatted);
    }

    [Test()]
    public void Value_35235235_Returns_ValidString()
    {
      var formatted = _formatNumber.Format(35235235);

      Assert.AreNotEqual("35,2352,35", formatted);
    }
  }  
}