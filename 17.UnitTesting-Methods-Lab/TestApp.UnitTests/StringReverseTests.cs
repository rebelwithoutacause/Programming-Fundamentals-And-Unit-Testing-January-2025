using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expexted = string.Empty;

        // Act
       string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(actual, expexted);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "1";
        string expected = "1";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "123";
        string expected = "321";

        // Act
       string actual = StringReverse.Reverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
