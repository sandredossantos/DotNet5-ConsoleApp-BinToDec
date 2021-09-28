using BinToDec.Domain.Interfaces;
using BinToDec.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BinToDec.Worker
{
    public class Worker
    {
        private readonly IConversionService _conversionService;
        private readonly IBinaryValidateService _binaryValidateService;

        public Worker(IConversionService conversionService, IBinaryValidateService binaryValidateService)
        {
            _conversionService = conversionService;
            _binaryValidateService = binaryValidateService;
        }
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Worker>().Run();
        }

        public void Run()
        {
            Console.WriteLine("Enter a value for binary to decimal conversion: ");
            var binary = Console.ReadLine();

            while (!_binaryValidateService.Validate(binary))
            {
                Console.WriteLine("The input value must be up to 8 characters of 0 or 1!");
                Console.WriteLine("Enter a value for binary to decimal conversion: ");
                binary = Console.ReadLine();
            };

            var result = _conversionService.ConvertBinaryToDecimal(binary);

            Console.WriteLine($"The equivalent value of binary {binary} in decimal is: {result}");
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Worker>();
                    services.AddTransient<IConversionService, ConversionService>();
                    services.AddTransient<IBinaryValidateService, BinaryValidateService>();
                });
        }
    }
}