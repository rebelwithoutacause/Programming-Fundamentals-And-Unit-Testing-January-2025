using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> numbers = new();
        List<int> expected = new();
        int controlNumber = 10;
        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, controlNumber);
        //Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        List<int> numbers = new() { 11, 27, 18, 19 };
        List<int> expected = new();
        int controlNumber = 10;
        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(expected, controlNumber);
        //Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {

        List<int> numbers = new() { 1, 2, 3, 4 };
        
        int controlNumber = 5;
        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, controlNumber);
        //Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {

        List<int> numbers = new() { 11, 27, 8, 9 };
        List<int> expected = new() { 8, 9 };
        int controlNumber = 10;
        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, controlNumber);
        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }
}
