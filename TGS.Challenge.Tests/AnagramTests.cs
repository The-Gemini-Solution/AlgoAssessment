using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TGS.Challenge.Tests
{
  [TestFixture()]
  public class AnagramTests
  {
    private readonly Anagram _anagram;

    public AnagramTests()
    {
       _anagram = new Anagram();
       
    }

    [Test]
    public void Word1_IsRequired()
    {
       var result = _anagram.AreAnagrams(string.Empty, "ABC");
       Assert.That(result, Is.False);
    }

    [Test()]
    public void Word2_IsRequired()
    {
       var result = _anagram.AreAnagrams("ABC", string.Empty);
       Assert.That(result, Is.False);
    }

    [Test()]
    public void Dormitory_IsAnagram_Dirty_room()
    {
      var result = _anagram.AreAnagrams("Dormitory", "Dirty_room");
      Assert.IsFalse(result);
    }

    [Test()]
    public void Funeral_IsAnagram_Reel_fun()
    {
      var result = _anagram.AreAnagrams("Funeral", "Reel fun");
      Assert.IsFalse(result);
    }

    [Test()]
    public void School_master_IsAnagram_The_classroom()
    {
      var result = _anagram.AreAnagrams("School master?!", "!?The classroom");
      Assert.IsTrue(result);
    }
    
    [Test()]
    public void Listen_Is_NOT_Anagram_Silence()
    {
      var result = _anagram.AreAnagrams("Listen", "Silence");
      Assert.IsFalse(result);
    }

    [Test()]
    public void Funeral_IsAnagram_Real_fun()
    {
      var result = _anagram.AreAnagrams("Funeral", "Real fun");
      Assert.IsTrue(result);
    }
  }
}