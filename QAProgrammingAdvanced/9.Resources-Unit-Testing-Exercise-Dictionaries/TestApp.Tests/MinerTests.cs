using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new[]
        {
        "gold 3",
        "Gold 5",
        "SILVER 10",
        "silver 20"
        };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new[]
        {
        "copper 8",
        "iron 17",
        "zinc 4",
        };
        string expected = $"copper -> 8{Environment.NewLine}" +
                          $"iron -> 17{Environment.NewLine}" +
                          $"zinc -> 4";

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
