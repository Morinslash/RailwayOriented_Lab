namespace LeapYear_ROP.Tests;

public class ParserShould
{
    [Fact]
    public void ReturnsSuccessIntWithValue5WhenProperInput()
    {
        const string userInput = "5";
        var result = Parser.Convert(userInput);
        var successResult = Assert.IsAssignableFrom<Success<int>>(result);
        Assert.Equal(5, successResult.Value);
    }

    [Fact]
    public void ReturnsFailureWithExceptionWhenUnparsableInput()
    {
        const string userInput = "invalid";
        var result = Parser.Convert(userInput);
        var failResult = Assert.IsAssignableFrom<Failure<int>>(result);
        Assert.Equal("Incorrect input, please provide year!", failResult.Message);
    }
}