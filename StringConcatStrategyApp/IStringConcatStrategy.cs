namespace StringConcatStrategyApp;

public interface IStringConcatStrategy
{
    // TODO: Define a method that generates a greeting string based on the provided Person object.
}

public class PlusOperatorStrategy
{
    // TODO: Implement the IStringConcatStrategy interface by defining the GenerateGreeting method
    // to concatenate the person's first and last name using the plus operator and return a greeting string.
    // "Hello, " + person.FirstName + " " + person.LastName + "!";
}

// TODO: Implement the StringBuilderStrategy class that should concatenate a greeting message using StringBuilder.

// TODO: Implement the StringFormatStrategy class that should concatenate a greeting message using string.Format.

// TODO: Implement the StringInterpolationStrategy class that should concatenate a greeting message using string interpolation.