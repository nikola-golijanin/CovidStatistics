using System.Globalization;
using CsvHelper;
using Entities.Enums;
using Entities.Models;
using Microsoft.Extensions.Configuration;
using Service.Contracts;

namespace Service;

public class CsvFileReaderService : IFileReaderService
{
    private readonly IConfiguration _configuration;
    private readonly string _filePath;
    
    public CsvFileReaderService(IConfiguration configuration)
    {
        _configuration = configuration;
        _filePath = _configuration.GetSection("FilePath").Value;

    }
    public IEnumerable<Case> ReadCasesFromFileBasedOnRegion(Region region)
    {
        using (var reader = new StreamReader(_filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            
            ConfigureCsvReaderBasedOnRegion(region,csv);
            var cases = csv.GetRecords<Case>();

            foreach (var record in cases)
            {
                record.Region = region.ToString();
                yield return record;
            }
        }
    }
    
    private void ConfigureCsvReaderBasedOnRegion(Region region, CsvReader csv)
    {
        switch (region)
        {
            case Region.LJ:
                csv.Context.RegisterClassMap<LjCaseMap>();
                break;
            case Region.CE:
                csv.Context.RegisterClassMap<CeCaseMap>();
                break;
            case Region.KR:
                csv.Context.RegisterClassMap<KrCaseMap>();
                break;
            case Region.NM:
                csv.Context.RegisterClassMap<NmCaseMap>();
                break;
            case Region.KK:
                csv.Context.RegisterClassMap<KkCaseMap>();
                break;
            case Region.KP:
                csv.Context.RegisterClassMap<KpCaseMap>();
                break;
            case Region.MB:
                csv.Context.RegisterClassMap<MbCaseMap>();
                break;
            case Region.MS:
                csv.Context.RegisterClassMap<MsCaseMap>();
                break;
            case Region.NG:
                csv.Context.RegisterClassMap<NgCaseMap>();
                break;
            case Region.PO:
                csv.Context.RegisterClassMap<PoCaseMap>();
                break;
            case Region.SG:
                csv.Context.RegisterClassMap<SgCaseMap>();
                break;
            case Region.ZA:
                csv.Context.RegisterClassMap<ZaCaseMap>();
                break;
            default:
                throw new Exception();
        }
    }
}