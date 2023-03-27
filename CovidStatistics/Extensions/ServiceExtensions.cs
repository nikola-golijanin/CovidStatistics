using Service;
using Service.Contracts;

namespace CovidStatistics.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IRegionService, RegionService>();
        services.AddScoped<IFileReaderService, CsvFileReaderService>();
    }
}