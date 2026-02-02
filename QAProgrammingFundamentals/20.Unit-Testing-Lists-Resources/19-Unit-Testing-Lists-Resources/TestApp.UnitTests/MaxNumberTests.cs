using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new List<int> { 4 };
        int expectedNumber = 4;

        // Act
        int actualNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(actualNumber, Is.EqualTo(expectedNumber));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int> { 4, 5, 6 };
        int expectedMaxNumber = 6;

        // Act
        int actualMaxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int> { -4, -5, -6 };
        int expectedMaxNumber = -4;

        // Act
        int actualMaxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int> { -4, 5, -6 };
        int expectedMaxNumber = 5;

        // Act
        int actualMaxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int> { -4, 5, -6, 5 };
        int expectedMaxNumber = 5;

        // Act
        int actualMaxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }
}
