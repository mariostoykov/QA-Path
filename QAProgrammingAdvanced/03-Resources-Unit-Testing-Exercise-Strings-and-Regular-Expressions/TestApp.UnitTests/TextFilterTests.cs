using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = " The girl wearing the yellow dress is my new neighbour.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new[] { "girl" };
        string text = " The girl wearing the yellow dress is my new neighbour.";
        string expected = " The **** wearing the yellow dress is my new neighbour.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new[] { "cat" };
        string text = " The girl wearing the yellow dress is my new neighbour.";
        string expected = " The girl wearing the yellow dress is my new neighbour.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new[] { "yellow dress" };
        string text = " The girl wearing the yellow dress is my new neighbour.";
        string expected = " The girl wearing the ************ is my new neighbour.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
