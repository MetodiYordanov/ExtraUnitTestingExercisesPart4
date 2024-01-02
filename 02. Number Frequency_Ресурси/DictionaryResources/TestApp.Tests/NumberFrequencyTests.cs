using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int inputNumber = 0;
        int expected = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(inputNumber);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int inputNumber = 8;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [8] = 1,
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(inputNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int inputNumber = 35353532;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [3] = 4,
            [5] = 3,
            [2] = 1,
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(inputNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int inputNumber = -2323233;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [2] = 3,
            [3] = 4,
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(inputNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
