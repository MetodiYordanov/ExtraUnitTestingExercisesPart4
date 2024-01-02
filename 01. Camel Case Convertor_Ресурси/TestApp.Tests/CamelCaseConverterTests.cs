using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "orange";
        string expected = "orange";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "sonic the hedgehog";
        string expected = "sonicTheHedgehog";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "Sonic tHe hedGehog";
        string expected = "sonicTheHedgehog";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
