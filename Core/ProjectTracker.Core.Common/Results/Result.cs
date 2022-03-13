namespace ProjectTracker.Core.Common.Results;

public class Result : IResult
{
    public bool Succesfull { get; set; }
    public ICollection<string?> Messages { get; private set; } = new List<string?>();

    public string? Message => Messages?.FirstOrDefault() ?? IResult.DEFAULT_ERROR_MESSAGE;

#if DEBUG
    public Exception? Exception { get; private set; }
#endif

    #region Public Methods

    //Fail
    public IResult FailResult(Exception ex)
    {
        Succesfull = false;

#if DEBUG
        Exception = ex;

        Messages.Add(ex.Message);
        Messages.Add(ex.StackTrace);
#endif

        return this;
    }
    public IResult FailResult(string message, Exception? ex = null)
    {
        Succesfull = false;

        Messages.Add(message);

#if DEBUG
        if (ex != null)
        {
            Exception = ex;
            Messages.Add(ex.Message);
            Messages.Add(ex.StackTrace);
        }
#endif

        return this;
    }
    public IResult FailResult(ICollection<string> messages, Exception? ex = null)
    {
        Succesfull = false;

        messages.ToList().ForEach(message => Messages.Add(message));

#if DEBUG
        if (ex != null)
        {
            Exception = ex;
            Messages.Add(ex.Message);
            Messages.Add(ex.StackTrace);
        }
#endif

        return this;
    }

    //FailAsync
    public async Task<IResult> FailResultAsync(Exception ex)
    {
        return await Task.Run(() => FailResult(ex));
    }
    public async Task<IResult> FailResultAsync(string message, Exception? ex = null)
    {
        return await Task.Run(() => FailResult(message, ex));
    }
    public async Task<IResult> FailResultAsync(ICollection<string> messages, Exception? ex = null)
    {
        return await Task.Run(() => FailResult(messages, ex));
    }

    //Success
    public IResult SuccessResult()
    {
        Succesfull = true;
        return this;
    }

    //SuccessAsync
    public async Task<IResult> SuccessResultAsync()
    {
        return await Task.Run(() => SuccessResult());
    }
    #endregion

    #region Static Helper Methods
    public static IResult Fail(Exception ex)
    {
        return new Result().FailResult(ex);
    }
    public static IResult Fail(string message, Exception? ex = null)
    {
        return new Result().FailResult(message, ex);
    }
    public static IResult Fail(ICollection<string> messages, Exception? ex = null)
    {
        return new Result().FailResult(messages, ex);
    }

    public static async Task<IResult> FailAsync(Exception ex)
    {
        return await new Result().FailResultAsync(ex);
    }
    public static async Task<IResult> FailAsync(string message, Exception? ex = null)
    {
        return await new Result().FailResultAsync(message, ex);
    }
    public static async Task<IResult> FailAsync(ICollection<string> messages, Exception? ex = null)
    {
        return await new Result().FailResultAsync(messages, ex);
    }

    public static IResult Success()
    {
        return new Result().SuccessResult();
    }
    public static async Task<IResult> SuccessAsync()
    {
        return await new Result().SuccessResultAsync();
    }
    public static async Task<IResult<T>> SuccessAsync<T>(T data)
    {
        return await new Result<T>().SuccessResultAsync(data);
    }
    public static IResult<T> Success<T>(T data)
    {
        return new Result<T>().SuccessResult(data);
    }

    public static IResult<T> Fail<T>(Exception ex)
    {
        var result = new Result<T>();
        result.FailResult(ex);

        return result;
    }
    public static IResult<T> Fail<T>(string message, Exception? ex = null)
    {
        var result = new Result<T>();
        result.FailResult(message, ex);

        return result;
    }
    public static IResult<T> Fail<T>(ICollection<string> messages, Exception? ex = null)
    {
        var result = new Result<T>();
        result.FailResult(messages, ex);

        return result;
    }
    
    public static async Task<IResult<T>> FailAsync<T>(Exception ex)
    {
        var result = new Result<T>();
        await result.FailResultAsync(ex);

        return await Task.FromResult(result);
    }
    public static async Task<IResult<T>> FailAsync<T>(string message, Exception? ex = null)
    {
        var result = new Result<T>();
        await result.FailResultAsync(message, ex);

        return await Task.FromResult(result);
    }
    public static async Task<IResult<T>> FailAsync<T>(ICollection<string> messages, Exception? ex = null)
    {
        var result = new Result<T>();
        await result.FailResultAsync(messages, ex);

        return await Task.FromResult(result);
    }
    #endregion
}

public class Result<T> : Result, IResult<T>
{
    public T? Data { get; private set; }

    public Result() { }
    public Result(T? data)
    {
        Data = data;
    }

    #region Public Methods
    public async Task<IResult<T>> SuccessResultAsync(T data)
    {
        return await Task.Run(() => SuccessResult(data));
    }
    public IResult<T> SuccessResult(T data)
    {
        Data = data;

        return this;
    }
    #endregion
}

//DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO | DEMO

//public class TestClass
//{
//    private readonly TestClass _productService;
//    public TestClass(TestClass productService)
//    {
//        _productService = productService;
//    }

//    public async Task GetProducts()
//    {
//        var result = await _productService.BasicSuccessTestMethod();

//        if (result.Succesfull)
//        {
//            return;
//        }

//        Console.WriteLine(result.Message);
//    }

//    public async Task Test()
//    {
//        var x = await _productService.FailTestMessageMethod();

//        if (!x.Succesfull)
//        {
//            Console.WriteLine(x.Message);
//            return;
//        }
//    }

//    public async Task<IResult> BasicSuccessTestMethod()
//    {
//        return await Result.SuccessAsync();
//    }
//    public async Task<IResult> BasicFailTestMessageMethod()
//    {
//        return await Result.FailAsync("Hello world!");
//    }
//    public async Task<IResult> BasicFailTestMessageWithExceptionMethod()
//    {
//        return await Result.FailAsync("Hello world!", new Exception());
//    }
//    public async Task<IResult> BasicFailTestMessagesMethod()
//    {
//        var messages = new List<string>();
//        messages.Add("Elma");
//        messages.Add("Armut");
//        return await Result.FailAsync(messages);
//    }
//    public async Task<IResult> BasicFailTestMessagesWithExceptionMethod()
//    {
//        var messages = new List<string>();
//        messages.Add("Elma");
//        messages.Add("Armut");
//        return await Result.FailAsync(messages, new Exception());
//    }


//    public async Task<IResult<int>> SuccessTestMethod()
//    {
//        return await Result.SuccessAsync(65536);
//    }
//    public async Task<IResult<int>> FailTestMessageMethod()
//    {
//        return await Result.FailAsync<int>("Hello world!");
//    }
//    public async Task<IResult<bool>> FailTestMessageWithExceptionMethod()
//    {
//        return await Result.FailAsync<bool>("Hello world!", new Exception());
//    }
//    public async Task<IResult<bool>> FailTestMessagesMethod()
//    {
//        var messages = new List<string>();
//        messages.Add("Elma");
//        messages.Add("Armut");
//        return await Result.FailAsync<bool>(messages);
//    }
//    public async Task<IResult<bool>> FailTestMessagesWithExceptionMethod()
//    {
//        var messages = new List<string>();
//        messages.Add("Elma");
//        messages.Add("Armut");
//        return await Result.FailAsync<bool>(messages, new Exception());
//    }
//}