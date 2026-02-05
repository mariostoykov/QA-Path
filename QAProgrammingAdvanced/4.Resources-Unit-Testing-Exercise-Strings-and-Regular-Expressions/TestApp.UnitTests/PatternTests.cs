using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("cat", 3, "cAtcAtcAt")]
    [TestCase("frog", 2, "fRoGfRoG")]
    [TestCase("a", 4, "aaaa")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "cat";
        int repetitionFactor = -2;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "dog";
        int repetitionFactor = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}
