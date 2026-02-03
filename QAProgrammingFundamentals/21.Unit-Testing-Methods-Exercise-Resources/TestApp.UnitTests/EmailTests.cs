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
        bool isValid = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(isValid);
    }


    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "test.example.com";

        // Act
        bool isValid = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.IsFalse(isValid);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string nullEmail = null;

        // Act
        bool isNull = Email.IsValidEmail(nullEmail);

        // Assert
        Assert.IsFalse(isNull);
    }
}
