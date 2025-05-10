using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        //Arrange
        string input = "5.5";
        string expected = "The input is not an integer!";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        string number = "0";
        string expected = $"The number {number} is zero.";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        string number = "-9";
        string expected = $"The number {number} is negative.";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        string number = "6";
        string expected = $"The number {number} is positive.";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(number);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
