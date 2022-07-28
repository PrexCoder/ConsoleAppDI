using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppDI.Collections
{
  public static class AppServicesCollection
  {
    public static void ConfigureAppServices(this IServiceCollection services)
    {
      services.AddLogging();
      services.AddTransient<ITestService, TestService>();
      services.AddSingleton<Executor>();
    }
  }
}
