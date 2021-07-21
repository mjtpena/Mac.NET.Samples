using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HelloWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly Random _random = new Random();  

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation(".NET Worker on MacOS running at: {time}", DateTimeOffset.Now);
                _logger.LogInformation($"This is a random number: {_random.Next(1000)}");
                
                await Task.Delay(7000, stoppingToken);
            }
        }
    }
}