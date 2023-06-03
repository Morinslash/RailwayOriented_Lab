namespace BasicExample;

public abstract class Result<T>
{
    // we are accepting delegate that will also return the Result<T> type
    // if current result would be a Failure<T> we would just return itself without invoking
    public abstract Result<T> OnSuccess(Func<T, Result<T>> func);
    // we are accepting an Action instead of the Func and it's invoke only when Failure<T>
    // if it's a Success<T> we just return itself
    public abstract Result<T> OnFailure(Action<string> action); //

    public static Result<T> Fail(string message) => new Failure<T>(message);
    public static Result<T> Ok(T value) => new Success<T>(value);
}