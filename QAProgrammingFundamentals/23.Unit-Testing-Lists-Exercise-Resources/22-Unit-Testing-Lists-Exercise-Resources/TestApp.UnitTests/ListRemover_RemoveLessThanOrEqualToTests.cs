using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> list = new();
        int treshold = 2;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThan(list, treshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmptyList()
    {
        // Arrange
        List<int> list = new() { 5, 7, 10 };
        int treshold = 2;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThan(list, treshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> list = new() { 1, 2, 4, 5 };
        int treshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThan(list, treshold);

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> list = new() { 1, 2, 4, 5, 6, 8 };
        int treshold = 5;
        List<int> expected = new() { 1, 2, 4, 5 };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThan(list, treshold);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
