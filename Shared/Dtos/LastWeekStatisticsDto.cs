using Entities.Enums;

namespace Shared.Dtos;

public class LastWeekStatisticsDto
{
    public string Region { get; set; }
    public int? AverageNumberOfCases { get; set; }
}