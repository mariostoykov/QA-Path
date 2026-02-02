using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();
        string expectedText = "";

        // Act
        string actualText = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.AreEqual(expectedText, actualText);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noEqualNumbersList = new List<int> { 1, 2, 3, 4, 5};
        string expected = "1 2 3 4 5";

        // Act
        string actualText = AdjacentEqual.Sum(noEqualNumbersList);

        // Assert
        Assert.AreEqual(noEqualNumbersList, actualText);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> EqualNumbersList = new List<int> { 1, 2, 2, 3, 4 };
        string expected = "1 4 3 4";

        // Act
        string actualText = AdjacentEqual.Sum(EqualNumbersList);

        // Assert
        Assert.AreEqual(expected, actualText);
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> EqualNumbersList = new List<int> { 2, 2, 2 };
        string expected = "6";

        // Act
        string actualText = AdjacentEqual.Sum(EqualNumbersList);

        // Assert
        Assert.AreEqual(expected, actualText);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> EqualNumbersList = new List<int> { 2, 2, 3 };
        string expected = "4 3";

        // Act
        string actualText = AdjacentEqual.Sum(EqualNumbersList);

        // Assert
        Assert.AreEqual(expected, actualText);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> EqualNumbersList = new List<int> { 2, 3, 4, 4 };
        string expected = "2 3 8";

        // Act
        string actualText = AdjacentEqual.Sum(EqualNumbersList);

        // Assert
        Assert.AreEqual(expected, actualText);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> EqualNumbersList = new List<int> { 1, 2, 2, 4 };
        string expected = "1 4 4";

        // Act
        string actualText = AdjacentEqual.Sum(EqualNumbersList);

        // Assert
        Assert.AreEqual(expected, actualText);
    }
}
