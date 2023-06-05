namespace LeapYear_ROP.Tests;

public class LeapCheckerShould
{
    [Fact(DisplayName = "Success when year is 1996")]
    public void ReturnSuccessWithYearIfDivisibleBy4()
    {
        const int year = 1996;
        var result = LeapChecker.IsLeap(year);
        var success = Assert.IsAssignableFrom<Success<int>>(result);
        Assert.Equal(1996, success.Value);
    }

    [Fact(DisplayName = "Failure when year is 1997")]
    public void ReturnFailureWithMessageIfNotDivisibleBy4()
    {
        const int year = 1997;
        var result = LeapChecker.IsLeap(year);
        var failure = Assert.IsAssignableFrom<Failure<int>>(result);
        Assert.Equal("1997 is not a leap year!", failure.Message);
    }

    [Fact(DisplayName = "Success when year is 1600")]
    public void ReturnSuccessWhenYearIsDivisibleBy400()
    {
        const int year = 1600;
        var result = LeapChecker.IsLeap(year);
        var success = Assert.IsAssignableFrom<Success<int>>(result);
        Assert.Equal(1600, success.Value);
    }

    [Fact(DisplayName = "Failure when year is 1800")]
    public void ReturnFailureWhenYearIsDivisibleBy100ButNotBy400()
    {
        const int year = 1800;
        var result = LeapChecker.IsLeap(year);
        var failure = Assert.IsAssignableFrom<Failure<int>>(result);
        Assert.Equal("1800 is not a leap year!", failure.Message);
    }
}