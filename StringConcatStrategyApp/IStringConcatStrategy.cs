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

public class StringBuilderStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        var sb = new System.Text.StringBuilder();
        sb.Append("Hello, ");
        sb.Append(person.FirstName);
        sb.Append(" ");
        sb.Append(person.LastName);
        sb.Append("!");
        return sb.ToString();
    }
}

// TODO: Implement the StringFormatStrategy class that should concatenate a greeting message using string.Format.

// TODO: Implement the StringInterpolationStrategy class that should concatenate a greeting message using string interpolation.