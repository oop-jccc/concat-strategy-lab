using StringConcatStrategyApp;

namespace StringConcatStrategyAppTests;

[TestFixture]
public class StringConcatStrategyTests
{
    private Person _testPerson;

    [SetUp]
    public void SetUp()
    {
        _testPerson = new Person("John", "Doe");
    }

    [Test]
    public void PlusOperatorStrategy_GenerateGreeting_ReturnsCorrectFormat()
    {
        var strategy = new PlusOperatorStrategy();
        var result = strategy.GenerateGreeting(_testPerson);
        Assert.That(result, Is.EqualTo("Hello, John Doe!"));
    }

    [Test]
    public void StringBuilderStrategy_GenerateGreeting_ReturnsCorrectFormat()
    {
        var strategy = new StringBuilderStrategy();
        var result = strategy.GenerateGreeting(_testPerson);
        Assert.That(result, Is.EqualTo("Hello, John Doe!"));
    }

    [Test]
    public void StringFormatStrategy_GenerateGreeting_ReturnsCorrectFormat()
    {
        var strategy = new StringFormatStrategy();
        var result = strategy.GenerateGreeting(_testPerson);
        Assert.That(result, Is.EqualTo("Hello, John Doe!"));
    }

    [Test]
    public void StringInterpolationStrategy_GenerateGreeting_ReturnsCorrectFormat()
    {
        var strategy = new StringInterpolationStrategy();
        var result = strategy.GenerateGreeting(_testPerson);
        Assert.That(result, Is.EqualTo("Hello, John Doe!"));
    }

    [Test]
    public void AllStrategies_GenerateGreeting_ReturnSameResult()
    {
        var strategies = new IStringConcatStrategy[]
        {
            new PlusOperatorStrategy(),
            new StringBuilderStrategy(),
            new StringFormatStrategy(),
            new StringInterpolationStrategy()
        };

        var results = strategies.Select(s => s.GenerateGreeting(_testPerson)).ToArray();
        
        // All results should be identical
        Assert.That(results.All(r => r == results[0]), Is.True);
        Assert.That(results[0], Is.EqualTo("Hello, John Doe!"));
    }
}
