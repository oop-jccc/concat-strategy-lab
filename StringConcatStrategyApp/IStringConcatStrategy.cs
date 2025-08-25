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

public class StringFormatStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        return string.Format("Hello, {0} {1}!", person.FirstName, person.LastName);
    }
}

public class StringInterpolationStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        return $"Hello, {person.FirstName} {person.LastName}!";
    }
}