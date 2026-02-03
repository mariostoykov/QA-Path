using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { 'A', '2', 'z', '!' };
        char[] expected = new char[] { 'A', 'z', '!' };

        // Act
        char result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { 'A', 'z', '!' };

        // Act
        char result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();

        // Act
        char result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.Empty); 
    }
}
