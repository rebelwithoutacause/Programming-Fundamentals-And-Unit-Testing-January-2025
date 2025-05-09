using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] inputArray = new[] { 1, -1, 0 };
        int[] expected = Array.Empty<int>();
        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        //Arrange
        int[] inputArray = new int[] { 4 };
        int[] expected = Array.Empty<int>();
        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);
        //Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        int[] inputArray = new int[] { 4, 6, 12, 10 };
        int[] expected = Array.Empty<int>();

        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        int[] inputArray = new int[] { 7 };
        int[] expected = new int[] { 7 };

        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        int[] inputArray = new int[] { 4, 6, 12, 10, 7, 2, 12, 5 };
        int[] expected = new int[] { 7, 2, 5 };

        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(inputArray);

        CollectionAssert.AreEqual (expected, actual);
    }
}
