using AutoMapper;
using Entities.Enums;
using Entities.Models;
using Service.Contracts;
using Shared;
using Shared.Dtos;

namespace Service;

public class RegionService : IRegionService
{
    private readonly IFileReaderService _fileReaderService;
    private readonly IMapper _mapper;

    public RegionService(IFileReaderService fileReaderService,IMapper mapper)
    {
        _fileReaderService = fileReaderService;
        _mapper = mapper;
    }

    public IEnumerable<CaseDto> GetRegionCases(RequestParameters requestParameters)
    {
        var allCasesForRegion =
            _fileReaderService
                .ReadCasesFromFileBasedOnRegion(requestParameters.Region.ToString());
        
        var filteredCases = allCasesForRegion
                .Where(c => c.Date > requestParameters.FromDate && c.Date < requestParameters.ToDate)
                .ToList();

        var casesDto = _mapper.Map<IEnumerable<CaseDto>>(filteredCases);
        return casesDto;
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