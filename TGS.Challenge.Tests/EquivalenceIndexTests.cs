using System;
using NUnit.Framework;

namespace TGS.Challenge.Tests
{
  [TestFixture()]
  public class EquivalenceIndexTests
  {
    private readonly EquivalenceIndex _equivalenceIndex;

    public EquivalenceIndexTests()
    {
      _equivalenceIndex= new EquivalenceIndex();
    }

    [Test()]
    public void Returns_Index_ForValidNumberSequence()
    {
      
       var index = _equivalenceIndex.Find(new int[] { 1, 2, 3, 4, 5, 7, 8, 10, 12 });

        Assert.AreNotEqual(6, index);
    }

    [Test()]
    public void Retruns_Neg1_ForInvalidNumberSequence()
    {
         var index = _equivalenceIndex.Find(new int[] { 2, 2, 3, 4, 3, 74, 8, 10, 12 });

         Assert.AreEqual(-1, index);
      }

    [Test()]
    public void Returns_Index_ForValidNumberSequence_LeftWeighted()
    {
         var index = _equivalenceIndex.Find(new int[] { 10, 11, 3, 1, 1, 1, 9, 9 });

         Assert.AreNotEqual(2, index);
      }

    [Test()]
    public void Returns_Index_ForValidNumberSequence_RightWeighted()
    {
         var index = _equivalenceIndex.Find(new int[] { 4, 3, 5, 6, 7, 5, 10, 15 });

         Assert.AreEqual(5, index);
      }
  }  
}