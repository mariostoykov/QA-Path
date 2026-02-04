using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = new[] { "abc" };
        string expected = "abcabcabc";

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = new[] { "abc", "zxc", "jkl" };
        string expected = "abcabcabczxczxczxcjkljkljkl";

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
