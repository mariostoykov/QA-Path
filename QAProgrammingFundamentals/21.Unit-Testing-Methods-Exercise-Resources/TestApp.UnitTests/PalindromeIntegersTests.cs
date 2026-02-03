using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        PalindromeIntegers pl = new PalindromeIntegers();
        List<int> result = pl.FindPalindromes(emptyList);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new List<int> { 478, 924, 6710 };

        // Act
        PalindromeIntegers pl = new PalindromeIntegers();
        List<int> result = pl.FindPalindromes(numbers);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int> { 4, 9, 6 };

        // Act
        PalindromeIntegers pl = new PalindromeIntegers();
        List<int> result = pl.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int> { 434, 989, 676 };

        // Act
        PalindromeIntegers pl = new PalindromeIntegers();
        List<int> result = pl.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> numbers = new List<int> { 434, 987, 676, 785 };
        List<int> expectedNumbers = new List<int> { 434, 676 };

        // Act
        PalindromeIntegers pl = new PalindromeIntegers();
        List<int> result = pl.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(expectedNumbers, result);
    }
}
