using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] array = Array.Empty<int>();
        string expected = string.Empty;

        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] array = new int[] { 4, 3, 2 };
        string expected = "4 3 2";

        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] array = new int[] { 1 };
        int expected = "1";

        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] array = new int[] { 14, 24, 3, 19, 15, 17 };
        int expected = "24 19 17";

        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

