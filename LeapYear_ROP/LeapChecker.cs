namespace LeapYear_ROP;

public static class LeapChecker
{
    public static Result<int> IsLeap(int year) =>
        CheckYear(year) ? Result<int>.Ok(year) : Result<int>.Fail($"{year} is not a leap year!");

    private static bool CheckYear(int year) =>
        DivisibleBy(4, year) && (DivisibleBy(400, year) || !DivisibleBy(100, year));

    private static bool DivisibleBy(int factor, int year) => year % factor is 0;
}