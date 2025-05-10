using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.AreEqual(0, result.Length);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 3, 10, 9 };
        int[] expected = { 1, 2, 3, 10, 9 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Act

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = new int[] { 1, 2, 3, 3 };
        int[] expected = new int[] { 1, 2, 3 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Act

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = new int[] { 1, 1, 1, 1, 1, 1 };
        int[] expected = new int[] { 1 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
