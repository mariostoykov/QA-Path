using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;
        
        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] array = new int[] { 1 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] array = new int[] { -1, -1, 3, 4, 5 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] array = new int[] { 2, 2, 2, 2, 2 };
        int expected = 2;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] array = new int[] { 1, 1, 2, 2, 3, 4 };
        int expected = 2;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
