public class ResponseApi<T>
{
    public ResponseApi(T data,
                          List<String> errors)
    {
        Data = data;
        Errors = errors;
    }

    public ResponseApi(T data)
    {
        Data = data;
        Errors = new();
    }

    public ResponseApi(List<String> errors)
    {
        Errors = errors;
    }

    public ResponseApi(String errors)
    {
        Errors.Add(errors);
    }
    public T? Data { get; private set; }

    public List<String> Errors { get; private set; } = new();
}