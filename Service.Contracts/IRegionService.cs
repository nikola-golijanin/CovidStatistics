using Entities.Models;
using Shared;
using Shared.Dtos;

namespace Service.Contracts;

public interface IRegionService
{
    IEnumerable<Case> GetRegionCases(RequestParameters requestParameters);
    IEnumerable<LastWeekStatisticsDto> GetLastweekStatistics();
}