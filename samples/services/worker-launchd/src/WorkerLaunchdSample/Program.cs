using Microsoft.Extensions.Hosting;
using WorkerLaunchdSample;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<HeartbeatState>();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();

public partial class Program;
