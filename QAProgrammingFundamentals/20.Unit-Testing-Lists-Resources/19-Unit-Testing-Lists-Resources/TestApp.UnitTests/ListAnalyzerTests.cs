using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new();
        string expectedText = "No elements!";

        // Act
        string resultText = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.AreEqual(expectedText, resultText);
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> oneElementList = new List<int> { 5 };
        string expectedText = "Element count: 1, Min value: 5, Max value: 5, Avg: 5.00";

        // Act
        string resultText = ListAnalyzer.Analyze(oneElementList);

        // Assert
        Assert.AreEqual(expectedText, resultText);
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> sameValueList = new List<int> { 5, 5, 5 };
        string expectedText = "Element count: 3, Min value: 5, Max value: 5, Avg: 5.00";

        // Act
        string resultText = ListAnalyzer.Analyze(sameValueList);

        // Assert
        Assert.AreEqual(expectedText, resultText);
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> differentValuesList = new List<int> { 3, 4, 5, 6 };
        string expectedText = "Element count: 4, Min value: 3, Max value: 6, Avg: 4.50";

        // Act
        string resultText = ListAnalyzer.Analyze(differentValuesList);

        // Assert
        Assert.AreEqual(expectedText, resultText);
    }
}
