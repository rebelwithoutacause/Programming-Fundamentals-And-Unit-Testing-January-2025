using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Arrange
        int number = 0;
        int expected = 0;

        //Act
        int actual = Fibonacci.CalculateFibonacci(number);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        //Arrange
        int number = 9;
        int expected = 34;

        //Act
        int actual = Fibonacci.CalculateFibonacci(number);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}