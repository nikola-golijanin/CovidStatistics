using Entities.Enums;
using Entities.Models;

namespace Service.Contracts;

public interface IFileReaderService
{
    IEnumerable<Case> ReadCasesFromFileBasedOnRegion(string region);
}