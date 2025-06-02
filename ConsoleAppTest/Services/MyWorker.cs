using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTest.Services
{
    public class MyWorker : IHostedService
    {
        private readonly IGreetingService _greetingService;
        private readonly ILogger<MyWorker> _logger;

        public MyWorker(IGreetingService greetingService, ILogger<MyWorker> logger)
        {
            _greetingService = greetingService;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Worker started");
            _greetingService.Greet("Robyn");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Worker stopping");
            return Task.CompletedTask;
        }
    }
}
