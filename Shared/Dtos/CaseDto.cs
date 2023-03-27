namespace Shared.Dtos;

public class CaseDto
{
    public DateTime Date { get; set; }
    public string Region { get; set; }
    public int? NumberOfActiveCases { get; set; }
    public int? NumberOfVacinatedFirst { get; set; }
    public int? NumberOfVacinatedSecond { get; set; }
    public int? DeceasedToDate { get; set; }
}