namespace StringConcatStrategyApp;

public interface IStringConcatStrategy
{
    string GenerateGreeting(Person person);
}

public class PlusOperatorStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        return "Hello, " + person.FirstName + " " + person.LastName + "!";
    }
}

// TODO: Implement the StringBuilderStrategy class that should concatenate a greeting message using StringBuilder.

// TODO: Implement the StringFormatStrategy class that should concatenate a greeting message using string.Format.

// TODO: Implement the StringInterpolationStrategy class that should concatenate a greeting message using string interpolation.