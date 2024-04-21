namespace Production.Enterprise.Domain.Entities.Frameworks
{
    public class Result
    {
        public ResultCodes Code { get; set; }
        public string? Message { get; set; }
    }

    public class Result<T> : Result
    {
        public T? Entity { get; set; }
    }

    public enum ResultCodes : int
    {
        Ok = 0,
        Error = 1,
        NotFound = -1
    }
}
