﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstList = new ();
        List<int> secondList = new List<int>() { 1, 2, 3 };
        //Act
        List<int> result = SameValues.FindSameValues (firstList, secondList);
        //Assert
        Assert.That (result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new();
        //Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>() { 4,  5, 6 };
        //Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>() { 4, 3, 2 };
        List<int> expectedList = new List<int>() { 2, 3 };
        //Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);
        //Assert
        CollectionAssert.AreEquivalent(expectedList, result);
    }
}
