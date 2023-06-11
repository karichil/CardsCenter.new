// See https://aka.ms/new-console-template for more information

using Serilog;
    
    Log.Logger = new LoggerConfiguration()
.MinimumLevel.Debug()
.WriteTo.File("log-test.txt")
.CreateLogger();

try
{
Log.Information("Starting up"); 
}
catch (Exception ex)
{
Log.Fatal(ex, "Application start-up failed");
}
finally
{
Log.CloseAndFlush();
}
Console.WriteLine("Hello World!");
Console.ReadKey();
Console.WriteLine("Hello, World!");