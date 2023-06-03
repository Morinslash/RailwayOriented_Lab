namespace BasicExample;

public class Success<T> : Result<T>
{
    public T Value { get; }

    public Success(T value)
    {
        Value = value;
    }

    public override Result<T> OnSuccess(Func<T, Result<T>> func)
    {
        return func(Value);
    }

    public override Result<T> OnFailure(Action<string> action)
    {
        return this;
    }
}