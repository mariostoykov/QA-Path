using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 1, -2, 5 };
        string expectedText = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);

    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 8, 10, 2 };
        string expectedText = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);

    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 2.20, 2.80, 3 };
        string expectedText = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);

    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 3.20, 2.99, 3 };
        string expectedText = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 3.70, 4.10, 4 };
        string expectedText = "Good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 5.20, 5.30, 5 };
        string expectedText = "Very good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double> { 5.80, 5.90, 6 };
        string expectedText = "Excellent";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.AreEqual(expectedText, result);
    }
}
