using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(emptyList);

        // Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> list = new() { 2, 4, 6 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(list);

        // Assert
        CollectionAssert.AreEqual(list, result.evens);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> list = new() { 1, 3, 5 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(list);

        // Assert
        CollectionAssert.AreEqual(list, result.odds);
        Assert.That(result.evens, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 5 };
        List<int> expectedEvens = new() { 2, 4 };
        List<int> expectedOdds = new() { 1, 3, 5 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(list);

        // Assert
        CollectionAssert.AreEqual(expectedEvens, result.evens);
        CollectionAssert.AreEqual(expectedOdds, result.odds);
    }
}
