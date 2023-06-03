namespace BasicExample;

public static class Calculator
{
    public static Result<double> Add(double a, double b) => Result<double>.Ok(a + b);

    public static Result<double> Divide(double a, double b)
    {
        double result;
        try
        {
            return b == 0 ? throw new DivideByZeroException() : Result<double>.Ok(a / b);
        }
        catch (DivideByZeroException e)
        {
            return Result<double>.Fail(e.Message);
        }
    }
}