using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerLaunchdSample;

public sealed class Worker(
    ILogger<Worker> logger,
    HeartbeatState state,
    TimeProvider timeProvider) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Worker started.");

        while (!stoppingToken.IsCancellationRequested)
        {
            var status = state.Update(timeProvider.GetUtcNow());
            logger.LogInformation("Heartbeat: {Status}", status);
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }

        logger.LogInformation("Worker stopped.");
    }
}
