using Entities.Enums;
using Entities.Models;
using Service.Contracts;
using Shared;
using Shared.Dtos;

namespace Service;

public class RegionService : IRegionService
{
    private readonly IFileReaderService _fileReaderService;

    public RegionService(IFileReaderService fileReaderService)
    {
        _fileReaderService = fileReaderService;
    }

    public IEnumerable<Case> GetRegionCases(RequestParameters requestParameters)
    {
        var allCasesForRegion = _fileReaderService.ReadCasesFromFileBasedOnRegion(requestParameters.Region.ToString());
        return allCasesForRegion
            .Where(c => c.Date > requestParameters.FromDate && c.Date < requestParameters.ToDate)
            .ToList();
    }

    public IEnumerable<LastWeekStatisticsDto> GetLastweekStatistics()
    {
        IList<LastWeekStatisticsDto> lastWeekStatistics = new List<LastWeekStatisticsDto>();

        foreach (var region in Enum.GetNames(typeof(Region)))
        {
            var allLastweekCasesForRegions =
                _fileReaderService
                    .ReadCasesFromFileBasedOnRegion(region)
                    .Where(c => c.Date > DateTime.Today.AddDays(-7));

            int? numberOfActiveCases = 0;
            foreach (var regionCase in allLastweekCasesForRegions)
            {
                numberOfActiveCases += regionCase.NumberOfActiveCases;
            }

            lastWeekStatistics.Add(new LastWeekStatisticsDto
            {
                Region = region,
                AverageNumberOfCases = numberOfActiveCases / 7
            });
        }
        
        return lastWeekStatistics;
    }
}