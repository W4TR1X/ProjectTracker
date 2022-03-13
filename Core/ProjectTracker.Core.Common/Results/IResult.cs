namespace ProjectTracker.Core.Common.Results;

public interface IResult
{
    public const string DEFAULT_ERROR_MESSAGE = "An Error Occurred";

    bool Succesfull { get; set; }
    ICollection<string?> Messages { get; }
    string? Message { get; }

#if DEBUG
    public Exception? Exception { get; }
#endif

    IResult FailResult(Exception ex);
    IResult FailResult(string message, Exception? ex = null);
    IResult FailResult(ICollection<string> messages, Exception? ex = null);

    Task<IResult> FailResultAsync(string message, Exception? ex = null);
    Task<IResult> FailResultAsync(ICollection<string> messages, Exception? ex = null);

    IResult SuccessResult();
    Task<IResult> SuccessResultAsync();
}

public interface IResult<T> : IResult
{
    T? Data { get; }

    IResult<T> SuccessResult(T data);
    Task<IResult<T>> SuccessResultAsync(T data);
}