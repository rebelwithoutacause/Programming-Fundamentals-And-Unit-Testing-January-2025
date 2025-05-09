using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        int[] numbers = Array.Empty<int>(); 

        // Act
        int result = EvenOddSubtraction.FindDifference(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(0));  
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] inputArray = new int[] { 2, 4, 6 };
        int expected = 12;
        // Act
        
        int actual = EvenOddSubtraction.FindDifference(inputArray);
        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        //Arrange
        int[] inputArray = new[] { 1, 3, 5 };
        int expected = -9;
        //Act
        int actual = EvenOddSubtraction.FindDifference(inputArray);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        //Arrange
        int[] inputArray = new int[] { 2, 4, 6, 1, 3, 5 };
        int expected = 12 - 9;

        //Act
        int actual = EvenOddSubtraction.FindDifference(inputArray);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
