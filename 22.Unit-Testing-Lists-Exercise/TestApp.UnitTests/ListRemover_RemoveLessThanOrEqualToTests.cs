using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        //Arrange
        List<int> numbers = new();
        int controlNumber = 5;
        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, controlNumber);
        //Assert
        Assert.That(result,Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5};
        int controlNumber = 5;
        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, controlNumber);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        List<int> numbers = new() { 6, 7, 8, 9};
        int controlNumber = 5;
        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, controlNumber);
        //Assert
        CollectionAssert.AreEqual(numbers, result);
        
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        List<int> numbers = new() { 11, 27, 8, 9 };
        List<int> expected = new() { 11, 27 };
        int controlNumber = 10;
        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, controlNumber);
        //Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
