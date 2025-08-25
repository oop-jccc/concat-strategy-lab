namespace StringConcatStrategyApp;

public static class UserInputValidator
{
    private const int MinChoice = 1;
    private const int MaxChoice = 4;

    public static bool IsValidChoice(string? input, out int choice)
    {
        choice = 0;

        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        if (!int.TryParse(input, out choice))
        {
            return false;
        }

        return choice >= MinChoice && choice <= MaxChoice;
    }
}