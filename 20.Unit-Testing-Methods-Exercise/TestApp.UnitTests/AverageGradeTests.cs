using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new() { 1.50, 1.00, 2.20 };
        string expected = "Incorrect grades";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new() { 6.50, 7.00, 6.20 };
        string expected = "Incorrect grades";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        //Arrange
        List<double> grades = new() { 2.50, 2.80, 2.70 };
        string expected = "Fail";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        List<double> grades = new() { 3.30, 3.40, 3.00 };
        string expected = "Poor";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        List<double> grades = new() { 4.20, 4.30, 4.00 };
        string expected = "Good";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        List<double> grades = new() { 4.50, 4.90, 5.25 };
        string expected = "Very good";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        List<double> grades = new() { 5.50, 5.90, 6.00 };
        string expected = "Excellent";

        string result = AverageGrade.GetGradeDefinition(grades);

        Assert.That(result, Is.EqualTo(expected));
    }
}
