using KOTA_API;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddWindowsService(options =>
{
    options.ServiceName = "KOTA_API";
});

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();