using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration(x =>
    {
        x.AddJsonFile("local.settings.json");
        x.AddJsonFile("host.json");
    })
    .Build();

host.Run();