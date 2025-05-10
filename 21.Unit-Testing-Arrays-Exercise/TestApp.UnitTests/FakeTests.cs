using NUnit.Framework;

using System;
using System.ComponentModel.DataAnnotations;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] input = new char[] { 'a', '6', 'b' };
        char[] expected = new char[] { 'a', 'b' };
        //Act
        char[] actual = Fake.RemoveStringNumbers(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] input = new char[] { 'a' };
        char[] expected = new char[] { 'a' };
        //Act
        char[] actual = Fake.RemoveStringNumbers(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] input = new char[] { };
        char[] expected = new char[] { };
        //Act
        char[] actual = Fake.RemoveStringNumbers(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
