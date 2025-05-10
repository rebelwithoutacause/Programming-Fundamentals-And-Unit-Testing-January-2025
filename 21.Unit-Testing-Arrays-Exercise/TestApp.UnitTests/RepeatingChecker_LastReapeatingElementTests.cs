using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] input = Array.Empty<int>();
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        int[] input = new int[] { 3 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        int[] input = new int[] { 3, 5, 8, 10 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        int[] input = new int[] { -10, -10 };
        int expected = -10;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        int[] input = new int[] { 6, 5, 6, 5 };
        int expected = 6;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        int[] input = new int[] { 5, 6, -7, 8, 6, -7, 8 };
        int expected = 6;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
