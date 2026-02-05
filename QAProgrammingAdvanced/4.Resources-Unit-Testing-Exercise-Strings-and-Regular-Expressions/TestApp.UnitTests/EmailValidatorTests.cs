using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("example@example.com")]
    [TestCase("user_name@example.co.uk")]
    [TestCase("user123@example.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("example@examplecom")]
    [TestCase("@usernameexample.co.uk")]
    [TestCase("user123")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
