using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] numbers = { 42 };
        int expected = 42;

        // Act
        double result = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange 

        int[] inputNumbers = new[] { 1, 2, 3 };
        double expected = 2.0;
        //Act
        double actual = Average.CalculateAverage(inputNumbers);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange 
        int[] inputNumbers = new int[] { -2, -4 };
        double expected = -6.0 / 2;

        // Act
        double actual = Average.CalculateAverage(inputNumbers);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        int[] inputNumbers = new[] { 5, 10, -5, -10 };
        double expected = 0;

        double actual = Average.CalculateAverage(inputNumbers);

        Assert.That(actual,Is.EqualTo(expected));
    }
}
