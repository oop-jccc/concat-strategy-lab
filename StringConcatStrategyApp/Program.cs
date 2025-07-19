namespace StringConcatStrategyApp;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Choose a string concatenation method (1-4):");
        Console.WriteLine("1. + Operator");
        Console.WriteLine("2. StringBuilder");
        Console.WriteLine("3. String Format");
        Console.WriteLine("4. String Interpolation");

        var input = Console.ReadLine();

        if (!UserInputValidator.IsValidChoice(input, out var choice))
        {
            Console.WriteLine("Invalid input. Exiting.");
            return;
        }

        // TODO: Uncomment the following after you implement GreetingService to take a strategy as a constructor parameter
        // var strategy = StringConcatStrategyFactory.CreateStrategy(choice);
        var service = new GreetingService( /*strategy*/);
        var person = new Person("John", "Doe");
        // service.DisplayGreeting(person);
    }
}