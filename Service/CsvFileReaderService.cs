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
    public IEnumerable<Case> ReadCasesFromFileBasedOnRegion(string region)
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
    
    private void ConfigureCsvReaderBasedOnRegion(string region, CsvReader csv)
    {
        switch (region)
        {
            case "LJ":
                csv.Context.RegisterClassMap<LjCaseMap>();
                break;
            case "CE":
                csv.Context.RegisterClassMap<CeCaseMap>();
                break;
            case "KR":
                csv.Context.RegisterClassMap<KrCaseMap>();
                break;
            case "NM":
                csv.Context.RegisterClassMap<NmCaseMap>();
                break;
            case "KK":
                csv.Context.RegisterClassMap<KkCaseMap>();
                break;
            case "KP":
                csv.Context.RegisterClassMap<KpCaseMap>();
                break;
            case "MB":
                csv.Context.RegisterClassMap<MbCaseMap>();
                break;
            case "MS":
                csv.Context.RegisterClassMap<MsCaseMap>();
                break;
            case "NG":
                csv.Context.RegisterClassMap<NgCaseMap>();
                break;
            case "PO":
                csv.Context.RegisterClassMap<PoCaseMap>();
                break;
            case "SG":
                csv.Context.RegisterClassMap<SgCaseMap>();
                break;
            case "ZA":
                csv.Context.RegisterClassMap<ZaCaseMap>();
                break;
            default:
                throw new Exception();
        }
    }
}