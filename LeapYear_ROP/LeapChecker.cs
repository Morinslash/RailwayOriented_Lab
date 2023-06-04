namespace LeapYear_ROP;

public static class LeapChecker
{
    public static Result<int> IsLeap(int year)
    {
        return year % 4 is 0 ? Result<int>.Ok(year) : Result<int>.Fail($"{year} is not a leap year!");
    }
}