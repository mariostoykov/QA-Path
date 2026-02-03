using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int number = 0;
        int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int input = 5;
        int expected = 5;

        // Act
        int actual = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}