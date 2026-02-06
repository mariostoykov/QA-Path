using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Аrrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result,Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new[] { "basil" };
        string expected = $"Plants with 5 letters:{Environment.NewLine}basil";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new[] { "basil", "cactus", "rose" };
        string expected = $"Plants with 4 letters:{Environment.NewLine}rose{Environment.NewLine}" +
                          $"Plants with 5 letters:{Environment.NewLine}basil{Environment.NewLine}" +
                          $"Plants with 6 letters:{Environment.NewLine}cactus";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new[] { "bASIl", "CactuS", "ROSE" };
        string expected = $"Plants with 4 letters:{Environment.NewLine}ROSE{Environment.NewLine}" +
                          $"Plants with 5 letters:{Environment.NewLine}bASIl{Environment.NewLine}" +
                          $"Plants with 6 letters:{Environment.NewLine}CactuS";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
