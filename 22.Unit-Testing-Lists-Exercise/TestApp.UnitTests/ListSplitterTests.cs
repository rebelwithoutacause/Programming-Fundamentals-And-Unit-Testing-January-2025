﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        //Arrange
        List<int> numbers = new();

        //Act
        (List<int> evens, List<int> odds) result =ListSplitter.SplitEvenAndOdd(numbers);
        //Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        //Arrange
        List<int> numbers = new() { 2, 4, 6, 8};

        //Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);
        //Assert
        CollectionAssert.AreEqual(numbers, result.evens);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        //Arrange
        List<int> numbers = new() { 3, 5, 7, 9 };

        //Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);
        //Assert
        CollectionAssert.AreEqual(numbers, result.odds);
        Assert.That(result.evens, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        //Arrange
        List<int> numbers = new() { 2, 4, 6, 8, 1, 3, 7};
        List<int> evenNumbers = new() { 2, 4, 6, 8 };
        List<int> oddNumbers = new() { 1, 3, 7};

        //Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);
        //Assert
        CollectionAssert.AreEqual(evenNumbers, result.evens);
        CollectionAssert.AreEqual(oddNumbers, result.odds);
    }
}
