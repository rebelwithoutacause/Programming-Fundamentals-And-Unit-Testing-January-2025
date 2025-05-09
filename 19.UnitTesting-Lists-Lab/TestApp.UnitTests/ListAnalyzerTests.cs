using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = "No elements!";

        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> oneElementList = new() { 42 };

        // Act
        string expected = $"Element count: 1, Min value: 42, Max value: 42, Avg: 42.00.";
        string result = ListAnalyzer.Analyze(oneElementList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> sameValuesList = new() { 1, 1, 1, 1 };

        // Act
        string expected = $"Element count: 4, Min value: 1, Max value: 1, Avg: 1.00.";
        string result = ListAnalyzer.Analyze(sameValuesList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DifferentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> mixedValuesList = new() { 1, 3, 8, 6 };

        // Act
        string expected = $"Element count: 4, Min value: 1, Max value: 8, Avg: 4.50.";
        string result = ListAnalyzer.Analyze(mixedValuesList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
