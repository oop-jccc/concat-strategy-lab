using StringConcatStrategyApp;

namespace StringConcatStrategyAppTests;

[TestFixture]
public class GreetingServiceTests
{
    private Person _testPerson;

    [SetUp]
    public void SetUp()
    {
        _testPerson = new Person("Jane", "Smith");
    }

    [Test]
    public void Constructor_NullStrategy_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new GreetingService(null!));
    }

    [Test]
    public void DisplayGreeting_WithValidStrategy_CallsStrategyGenerateGreeting()
    {
        var mockStrategy = new TestStringConcatStrategy();
        var service = new GreetingService(mockStrategy);

        // Capture console output
        using var sw = new StringWriter();
        Console.SetOut(sw);

        service.DisplayGreeting(_testPerson);

        var output = sw.ToString().Trim();
        Assert.That(output, Is.EqualTo("Test greeting for Jane Smith"));
        Assert.That(mockStrategy.WasCalled, Is.True);
        Assert.That(mockStrategy.CalledWithPerson, Is.EqualTo(_testPerson));
    }

    [Test]
    public void DisplayGreeting_WithPlusOperatorStrategy_OutputsCorrectGreeting()
    {
        var strategy = new PlusOperatorStrategy();
        var service = new GreetingService(strategy);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        service.DisplayGreeting(_testPerson);

        var output = sw.ToString().Trim();
        Assert.That(output, Is.EqualTo("Hello, Jane Smith!"));
    }

    // Test helper class
    private class TestStringConcatStrategy : IStringConcatStrategy
    {
        public bool WasCalled { get; private set; }
        public Person? CalledWithPerson { get; private set; }

        public string GenerateGreeting(Person person)
        {
            WasCalled = true;
            CalledWithPerson = person;
            return $"Test greeting for {person.FirstName} {person.LastName}";
        }
    }
}
