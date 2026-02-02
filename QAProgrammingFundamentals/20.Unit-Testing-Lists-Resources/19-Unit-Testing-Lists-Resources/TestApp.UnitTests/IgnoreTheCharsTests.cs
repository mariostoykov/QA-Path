using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        // Arrange
        string sentance = "";
        List<char> ignoreChars = new List<char> { 'a', 'e' };

        // Act
        string resultSentance = IgnoreTheChars.IgnoreChars(sentance, ignoreChars);

        // Assert
        Assert.AreEqual(sentance, resultSentance);
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        // Arrange
        string sentance = "Hello World";
        List<char> ignoreChars = new List<char>();

        // Act
        string resultSentance = IgnoreTheChars.IgnoreChars(sentance, ignoreChars);

        // Assert
        Assert.AreEqual(sentance, resultSentance);
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        // Arrange
        string sentance = "H";
        List<char> ignoreChars = new List<char> { 'H' };
        string expectedSentace = "";

        // Act
        string resultSentance = IgnoreTheChars.IgnoreChars(sentance, ignoreChars);

        // Assert
        Assert.AreEqual(sentance, resultSentance);
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        // Arrange
        string sentance = "Hello";
        List<char> ignoreChars = new List<char> { 'H' };
        string expectedSentace = "ello";

        // Act
        string resultSentance = IgnoreTheChars.IgnoreChars(sentance, ignoreChars);

        // Assert
        Assert.AreEqual(sentance, resultSentance);
    }
}
