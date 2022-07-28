using ConsoleAppDI.Collections;
using Microsoft.Extensions.Hosting;

namespace ConsoleAppDI
{
  public class Main
  {
    public IHost Builder { get; set; } = null!;
    private static string[] _args { get; set; } = null!;
    public Main()
    {
      _args = Environment.GetCommandLineArgs();
      Builder = CreateHostBuilder();
    }

    public IHost CreateHostBuilder()
    {
      var builder = Host.CreateDefaultBuilder(_args)
          .ConfigureServices((hostContext, services) =>
          {
            services.ConfigureAppServices();
          }).Build();
      return builder;
    }
  }
}
