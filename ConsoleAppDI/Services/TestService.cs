namespace ConsoleAppDI.Services
{
  public class TestService : ITestService
  {
    public TestService()
    {
    }

    public void TestMethod()
    {
      Console.WriteLine("Works");
    }
  }
}
