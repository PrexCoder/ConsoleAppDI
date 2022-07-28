var main = new Main();

var executor = main.Builder.Services.GetService<Executor>();

if(executor != null)
{
  executor.TestServiceMethod();
}