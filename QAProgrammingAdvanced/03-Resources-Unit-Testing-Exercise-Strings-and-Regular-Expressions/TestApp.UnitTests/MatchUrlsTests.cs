using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "www.example.com";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "https://www.google.com";
        var expected = new List<string> { "https://www.google.com" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That (result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "https://www.google.com , https://www.example.com , https://www.youtube.com";
        var expected = new List<string>
    {
        "https://www.google.com",
        "https://www.example.com",
        "https://www.youtube.com"
    };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "\"https://www.google.com\", \"https://www.example.com\"";
        var expected = new List<string>
    {
        "https://www.google.com",
        "https://www.example.com",
    };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
