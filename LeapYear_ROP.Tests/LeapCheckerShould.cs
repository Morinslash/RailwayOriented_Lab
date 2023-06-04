namespace LeapYear_ROP.Tests;

public class LeapCheckerShould
{
    [Fact]
    public void ReturnSuccessWithYearIfDivisibleBy4()
    {
        const int year = 1996;
        var result = LeapChecker.IsLeap(year);
        var success = Assert.IsAssignableFrom<Success<int>>(result);
        Assert.Equal(1996, success.Value);
    }

    [Fact]
    public void ReturnFailureWithMessageIfNotDivisibleBy4()
    {
        const int year = 1997;
        var result = LeapChecker.IsLeap(year);
        var failure = Assert.IsAssignableFrom<Failure<int>>(result);
        Assert.Equal("1997 is not a leap year!", failure.Message); 
    }
}