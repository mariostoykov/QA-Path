using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = new int[] { -1, 0, 1 };

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = new int[] { 1 };

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = new int[] { 6,8,12 };

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arrange
        int[] array = new int[] { 7, 8, 12 };
        int[] expected = new int[] { 7 };

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arrange
        int[] array = new int[] { 2, 7, 8, 12, 11 };
        int[] expected = new int[] { 2, 7 , 11 };

        //Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
