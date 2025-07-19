using StringConcatStrategyApp;

namespace StringConcatStrategyAppTests;

[TestFixture]
public class UserInputValidatorTests
{
    [Test]
    public void IsValidChoice_ValidInput_ReturnsTrue()
    {
        var result = UserInputValidator.IsValidChoice("1", out var choice);
        Assert.That(result, Is.True);
        Assert.That(choice, Is.EqualTo(1));
    }

    [Test]
    public void IsValidChoice_InvalidInput_ReturnsFalse()
    {
        var result = UserInputValidator.IsValidChoice("invalid", out _);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidChoice_OutOfRangeInput_ReturnsFalse()
    {
        var result = UserInputValidator.IsValidChoice("5", out _);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidChoice_LowerBoundaryInput_ReturnsTrue()
    {
        var result = UserInputValidator.IsValidChoice("1", out var choice);
        Assert.That(result, Is.True);
        Assert.That(choice, Is.EqualTo(1));
    }

    [Test]
    public void IsValidChoice_UpperBoundaryInput_ReturnsTrue()
    {
        var result = UserInputValidator.IsValidChoice("4", out var choice);
        Assert.That(result, Is.True);
        Assert.That(choice, Is.EqualTo(4));
    }
}