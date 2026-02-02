using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(3.20, "Average")]
    [TestCase(3.80, "Good")]
    [TestCase(4.80, "Very Good")]
    [TestCase(5.60, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestCase(1.00, "Invalid!")]
    [TestCase(1.99, "Invalid!")]
    [TestCase(15.00, "Invalid!")]
    [TestCase(6.01, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
