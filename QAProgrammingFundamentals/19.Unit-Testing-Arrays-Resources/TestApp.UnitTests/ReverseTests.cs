using NUnit.Framework;

using System;
using System.Security.Cryptography.X509Certificates;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] arrayWithOneElement = new int[] { 42 };

        // Act
        string result = Reverse.ReverseArray(arrayWithOneElement);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] arrayWithMultipleElements = new int[] { 4,8,9 };
        string expected = "9 8 4";

        // Act
        string result = Reverse.ReverseArray(arrayWithMultipleElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
