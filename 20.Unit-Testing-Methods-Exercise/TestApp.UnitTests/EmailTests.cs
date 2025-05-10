using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "testexample.com";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string inputEmail = null;

        // Act
        bool result = Email.IsValidEmail(inputEmail);

        // Assert
        Assert.IsFalse(result);
    }
}
