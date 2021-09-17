using BinToDec.Domain.Interfaces;
using BinToDec.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BinToDec.Worker
{
    public class Worker
    {
        private readonly IConversionService _conversionService;

        public Worker(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Worker>().Run();
        }

        public void Run()
        {
            int value = _conversionService.ConvertBinaryToDecimal("");
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Worker>();
                    services.AddTransient<IConversionService, ConversionService>();
                });
        }
    }
}