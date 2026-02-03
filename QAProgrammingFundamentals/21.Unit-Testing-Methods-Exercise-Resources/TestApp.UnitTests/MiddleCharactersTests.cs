using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyString = "";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyString = " ";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string emptyString = "g";
        string expected = "g";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string emptyString = "tables";
        string expected = "bl";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string emptyString = "ghg";
        string expected = "h";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
