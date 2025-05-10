using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmptyArray_ReturnsZero()
    {
        int[] input = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        // Act
        int actual = Majority.IsEvenOrOddMajority(expected);

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        int[] input = new int[] { 0, 0, 0 };
        int[] result = new int[] { 0 };
       
        //Act
        int actual = Majority.IsEvenOrOddMajority(input);
        //Assert
        Assert.AreEqual(0, actual);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        int[] input = new int[] { 1, 3, 5, 2, 4, 6 };

        //Act
        int actual = Majority.IsEvenOrOddMajority(input);
        //Assert
        Assert.That(actual, Is.Zero);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        int[] input = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 1, 3, 5 };

        //Act
        int actual = Majority.IsEvenOrOddMajority(input);
        //Assert
        Assert.That(actual, Is.Positive);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        int[] input = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 2, 4, 6 };

        //Act
        int actual = Majority.IsEvenOrOddMajority(input);
        //Assert
        Assert.That(actual, Is.Negative);
    }
}
