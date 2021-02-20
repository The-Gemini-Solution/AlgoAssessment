using System;
using Xunit;

namespace TGS.Challenge.Tests
{
  public class AnagramTests
  {
    private readonly Anagram _anagram;

    public AnagramTests()
    {
      this._anagram = new Anagram();
    }

    [Fact]
    public void Word1_IsRequired()
    {
      Assert.Throws<ArgumentException>(() => _anagram.AreAnagrams(string.Empty, "ABC"));
    }

    [Fact]
    public void Word2_IsRequired()
    {
      Assert.Throws<ArgumentException>(() => _anagram.AreAnagrams("ABC", string.Empty));
    }

    [Fact]
    public void Dormitory_IsAnagram_Dirty_room()
    {
      var result = _anagram.AreAnagrams("Dormitory", "Dirty_room");

      Assert.True(result);
    }

    [Fact]
    public void Funeral_Is_NOT_Anagram_Reel_fun()
    {
      var result = _anagram.AreAnagrams("Funeral", "Reel fun");

      Assert.False(result);
    }

    [Fact]
    public void School_master_IsAnagram_The_classroom()
    {
      var result = _anagram.AreAnagrams("School master?!", "!?The classroom");

      Assert.True(result);
    }
    
    [Fact]
    public void Listen_Is_NOT_Anagram_Silence()
    {
      var result = _anagram.AreAnagrams("Listen", "Silence");

      Assert.False(result);
    }

    [Fact]
    public void Funeral_IsAnagram_Real_fun()
    {
      var result = _anagram.AreAnagrams("Funeral", "Real fun");

      Assert.True(result);
    }
  }
}