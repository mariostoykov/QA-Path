using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "cat" ;
        string expected = "tac";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal totalPrice = 20;
        decimal discount = 10;
        decimal expected = 18;

        // Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 20;
        decimal discount = -10;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40 };
        int index = 1;
        int expected = 20;

        // Act
        int result = this._exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40 };
        int index = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";

        // Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn, expected);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;
        string expected = "User logged in.";

        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn, expected), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        int input1 = 0;
        string input = "8";
        int expected = 8;

        // Act
        int result = this._exceptions.FormatExceptionParseInt(input1, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        int input1 = 0;
        string input = "cat";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input1, input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        var dictionary = new Dictionary<string, int>
        {
            { "cat", 35 },
            { "dog", 25 }
        };
        string key = "cat";
        int expected = 35;

        // Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        //Arrange
        var dictionary = new Dictionary<string, int>
        {
            { "cat", 35 },
            { "dog", 25 }
        };
        string key = "frog";
        int expected = 45;

        // Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 10;
        int b = 20;
        int expected = a + b;

        // Act
        int result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 1;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int dividend = 20;
        int divisor = 10;
        int expected = dividend / divisor;

        // Act
        int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 20;
        int divisor = 0;

        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(dividend, divisor), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 10, 20, 30, 40 };
        int index = 0;
        int expected = 100;

        // Act
        int result = this._exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collection = null;
        int index = 0;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 10, 20, 30, 40 };
        int index = 4;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>()
        {
            { "cat", "35" }
        };
        string key = "cat";
        int expected = 35;

        // Act
        int result = this._exceptions.GetElementAsNumber(dictionary, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>()
        {
            { "cat", "35" },
        };
        string key = "frog";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>()
        {
            { "cat", "number" },
        };
        string key = "cat";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, key), Throws.InstanceOf<FormatException>());
    }
}
