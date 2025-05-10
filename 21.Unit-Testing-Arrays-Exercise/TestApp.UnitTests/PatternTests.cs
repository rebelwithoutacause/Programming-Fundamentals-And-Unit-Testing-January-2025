using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        //Arrange
        int[] input = new int[] { 1, 2, 3, 3, 2, 1 };
        int[] expected = new int[] { 1, 3, 2 };
        //Act
        int []actual = Pattern.SortInPattern(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        int[] input = Array.Empty<int>();
        //Act
        int[] actual = Pattern.SortInPattern(input);
        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] input = new[] { 6 };
        int[] expected = { 6 };

        //Act
        int[] actual = Pattern.SortInPattern(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
