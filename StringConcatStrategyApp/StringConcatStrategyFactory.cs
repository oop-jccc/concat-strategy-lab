namespace StringConcatStrategyApp;

public static class StringConcatStrategyFactory
{
    public static IStringConcatStrategy CreateStrategy(int choice)
    {
        return choice switch
        {
            1 => new PlusOperatorStrategy(),
            2 => new StringBuilderStrategy(),
            3 => new StringFormatStrategy(),
            4 => new StringInterpolationStrategy(),
            _ => new PlusOperatorStrategy() // Default case
        };
    }
}
