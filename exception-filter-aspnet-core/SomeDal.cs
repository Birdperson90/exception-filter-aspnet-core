namespace ExceptionFilterAspNetCore
{
    public class SomeDal : ISomeDal
    {
        public void DoSomething()
        {
            throw new SomeException($"I promise to be caugt by the filter {nameof(SomeExceptionFilter)} and be returned as bad request!");
        }
    }
}