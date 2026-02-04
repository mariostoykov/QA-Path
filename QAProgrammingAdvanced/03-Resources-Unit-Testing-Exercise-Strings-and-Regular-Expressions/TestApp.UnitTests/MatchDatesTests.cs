using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string date = "31-Dec-2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(date);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "2022.Dec.31";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string date = "31-Dec-2022, 04-Feb-2023, 28-Sep-2025";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(date);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string date = string.Empty;
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(date);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string date = null;
        string expected = "Input cannot be null!";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(date));
    }
}
