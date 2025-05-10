using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "bob", "ava", "mom" };

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
       
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // TODO: finish t // Arrange
        List<string> words = new() { "ava" };

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result); 
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // TODO: finish t // Arrange
        List<string> words = new() { "boost", "rock", "mom" };

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> words = new() { "Ava", "SyS", "Mom" };

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }
}
