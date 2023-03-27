using Entities.Models;
using Shared;
using Shared.Dtos;

namespace Service.Contracts;

public interface IRegionService
{
    IEnumerable<CaseDto> GetRegionCases(RequestParameters requestParameters);
    IEnumerable<LastWeekStatisticsDto> GetLastweekStatistics();
}