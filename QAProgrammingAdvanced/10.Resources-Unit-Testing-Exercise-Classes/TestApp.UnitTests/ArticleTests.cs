using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void Setup()
    {
        this._article = new();
    }
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = {
        "Article X X",         // First article → Title = "Article"
        "X Content2 X",        // Second article → Content = "Content2"
        "X X Author3"          // Third article → Author = "Author3"
        };

        // Act
        Article result = this._article.AddArticles(articles);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        string[] articles = {
        "Zebra SomeContent SomeAuthor",
        "Apple OtherContent OtherAuthor",
        "Monkey MoreContent MoreAuthor"
        };

        Article result = this._article.AddArticles(articles);
        string expected = "Apple - OtherContent: OtherAuthor" + Environment.NewLine +
        "Monkey - MoreContent: MoreAuthor" + Environment.NewLine +
        "Zebra - SomeContent: SomeAuthor";

        // Act
        string output = this._article.GetArticleList(result, "title");

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        string[] articles = {
        "Zebra Content1 Author1",
        "Apple Content2 Author2",
        "Monkey Content3 Author3"
        };

        Article result = this._article.AddArticles(articles);
        string expected = "";

        // Act
        string output = this._article.GetArticleList(result, "invalid");

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
