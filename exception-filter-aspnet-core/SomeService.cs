namespace ExceptionFilterAspNetCore
{
    public class SomeService : ISomeService
    {
        private readonly ISomeDal someDal;

        public SomeService(ISomeDal someDal)
        {
            this.someDal = someDal;
        }

        public void DoSomething()
        {
            this.someDal.DoSomething();
        }
    }
}