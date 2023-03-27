using Entities.Models;
using Shared;

namespace Service.Contracts;

public interface IRegionService
{
    IEnumerable<Case> GetRegionCases(RequestParameters requestParameters);
}