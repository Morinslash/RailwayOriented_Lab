namespace LeapYear_ROP;

public abstract class Result<T>
{
    public abstract Result<T> OnSuccess(Func<T, Result<T>> func);
    public abstract Result<T> OnFailure(Action<string> action);
    
    public static Result<T> Fail(string exception) => new Failure<T>(exception);
    public static Result<T> Ok(T value) => new Success<T>(value);
}