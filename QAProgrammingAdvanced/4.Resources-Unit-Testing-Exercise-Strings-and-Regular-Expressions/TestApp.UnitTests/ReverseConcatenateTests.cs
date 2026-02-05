using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new[] { "abc" };
        string expected = "abc";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "abc", "zxc" };
        string expected = "zxcabc";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "abc", " zxc" };
        string expected = " zxcabc";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[1000];
        for (int i = 0; i < 1000; i++)
        {
            input[i] = ((char)('a' + (i % 26))).ToString();
        }
        string expected = string.Concat(input.Reverse());

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
