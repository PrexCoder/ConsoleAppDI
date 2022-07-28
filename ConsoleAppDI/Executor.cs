namespace ConsoleAppDI
{
  public class Executor
  {
    private readonly ITestService _testService;

    public Executor(ITestService testService)
    {
      _testService = testService;
    }

    public void TestServiceMethod()
    {
      _testService.TestMethod();
    }
  }
}
