namespace StringConcatStrategyApp;

public class GreetingService
{
    private readonly IStringConcatStrategy _strategy;

    public GreetingService(IStringConcatStrategy strategy)
    {
        _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public void DisplayGreeting(Person person)
    {
        var greeting = _strategy.GenerateGreeting(person);
        Console.WriteLine(greeting);
    }
}
