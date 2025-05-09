using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        //Arrange
        Calculate factorial = new();
        //Act
        int actual = Factorial.CalculateFactorial(0);
        //Assert
        Assert.AreEqual(1, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        Calculate factorial = new();
        //Act
        int actual = Factorial.CalculateFactorial(5);
        //Assert
        Assert.AreEqual(120, actual);
    }
}
