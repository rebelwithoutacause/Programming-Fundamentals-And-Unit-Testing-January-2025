using System;
using System.Linq;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        double[] inputArray = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        double[] actual = Sorting.ShallowAscendingSort(inputArray);

        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        double[] inputArray = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        double[] actual = Sorting.DeepAscendingSort(inputArray);

        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        double[] inputArray = new double[] { 3, 2, 1 };
        double[] expected = new double[] { 1, 2, 3 };

        double[] actual = Sorting.ShallowAscendingSort(inputArray);

        CollectionAssert.AreEqual(actual, expected);
        CollectionAssert.AreNotEqual(actual, inputArray); 
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        double[] inputArray = new double[] { 3, 2, 1 };
        double[] expected = new double[] { 1, 2, 3 };

        double[] actual = Sorting.DeepAscendingSort(inputArray);

        CollectionAssert.AreEqual(actual, expected);
        CollectionAssert.AreEqual(actual, inputArray); 
    }
}
