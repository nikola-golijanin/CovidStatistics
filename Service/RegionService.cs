using Entities.Models;
using Service.Contracts;
using Shared;

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
        var allCasesForRegion = _fileReaderService.ReadCasesFromFileBasedOnRegion(requestParameters.Region);
        return allCasesForRegion
            .Where(c => c.Date > requestParameters.FromDate && c.Date < requestParameters.ToDate)
            .ToList();
    }
}