using StringConcatStrategyApp;

// Test the application functionality manually
Console.WriteLine("Testing String Concatenation Strategies:");
Console.WriteLine("========================================");

var person = new Person("John", "Doe");

// Test each strategy
var strategies = new (int choice, string name, IStringConcatStrategy strategy)[]
{
    (1, "Plus Operator", new PlusOperatorStrategy()),
    (2, "StringBuilder", new StringBuilderStrategy()),
    (3, "String Format", new StringFormatStrategy()),
    (4, "String Interpolation", new StringInterpolationStrategy())
};

foreach (var (choice, name, strategy) in strategies)
{
    Console.WriteLine($"\nTesting {name} (Choice {choice}):");
    var service = new GreetingService(strategy);
    service.DisplayGreeting(person);
}

// Test factory
Console.WriteLine("\nTesting Factory:");
for (int i = 1; i <= 4; i++)
{
    var strategy = StringConcatStrategyFactory.CreateStrategy(i);
    var service = new GreetingService(strategy);
    Console.Write($"Choice {i}: ");
    service.DisplayGreeting(person);
}

// Test input validator
Console.WriteLine("\nTesting Input Validator:");
var testInputs = new[] { "1", "2", "3", "4", "5", "0", "invalid", "", null };
foreach (var input in testInputs)
{
    var isValid = UserInputValidator.IsValidChoice(input, out var choice);
    Console.WriteLine($"Input: '{input ?? "null"}' -> Valid: {isValid}, Choice: {choice}");
}

Console.WriteLine("\nAll tests completed successfully!");
