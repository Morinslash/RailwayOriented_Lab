namespace LeapYear_ROP;

public static class Parser
{
    public static Result<int> Convert(string userInput) =>
        int.TryParse(userInput, out var year) ? 
            Result<int>.Ok(year) : 
            Result<int>.Fail("Incorrect input, please provide year!");
}