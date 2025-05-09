using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        int size = 0;
        string expected = "";
        
        string actual = Triangle.PrintTriangle(size);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        //Arrange
        int inputNumber = 3;
        string expected = $"1" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1 2 3" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1";

        //Act 
        string result = Triangle.PrintTriangle(inputNumber);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        //Arrange
        int inputNumber = 5;
        string expected = $"1" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1 2 3" +
        $"{Environment.NewLine}1 2 3 4" +
        $"{Environment.NewLine}1 2 3 4 5" +
        $"{Environment.NewLine}1 2 3 4" +
        $"{Environment.NewLine}1 2 3" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1";
    }
}
