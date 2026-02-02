using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        List<int> resultList = ListManipulation.RemoveNegativesAndReverse(emptyList);

        // Assert
        CollectionAssert.IsEmpty(resultList);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        // Arrange
        List<int> negativeList = new List<int> { -3, -5, -8 };

        // Act
        List<int> resultList = ListManipulation.RemoveNegativesAndReverse(negativeList);

        // Assert
        CollectionAssert.IsEmpty(resultList);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        // Arrange
        List<int> onePositiveList = new List<int> { -3, 5, -8 };

        // Act
        List<int> resultList = ListManipulation.RemoveNegativesAndReverse(onePositiveList);

        // Assert
        CollectionAssert.AreEqual(onePositiveList, resultList);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        // Arrange
        List<int> onlyPositiveList = new List<int> { 3, 5, 8 };
        List<int> expectedList = new List<int> { 8, 5, 3 };

        // Act
        List<int> resultList = ListManipulation.RemoveNegativesAndReverse(onlyPositiveList);

        // Assert
        CollectionAssert.AreEqual(onlyPositiveList, resultList);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        // Arrange
        List<int> mixedList = new List<int> { -3, 5, -8, -12, 15};
        List<int> expectedList = new List<int> { 15, 5 };

        // Act
        List<int> resultList = ListManipulation.RemoveNegativesAndReverse(mixedList);

        // Assert
        CollectionAssert.AreEqual(mixedList, resultList);
    }
}
