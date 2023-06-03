namespace BasicExample;

public class Failure<T> : Result<T>
{
    public string Message { get; }

    public Failure(string message)
    {
        Message = message;
    }

    public override Result<T> OnSuccess(Func<T, Result<T>> func)
    {
        return this;
    }

    public override Result<T> OnFailure(Action<string> action)
    {
        action(Message);
        return this;
    }
}