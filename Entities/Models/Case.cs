namespace Entities.Models;

public class Case
{
    public DateTime Date { get; set; }
    
    public int? NumberOfActiveCases { get; set; }
    
    public int? NumberOfVacinatedFirst { get; set; }
    
    public int? NumberOfVacinatedSecond { get; set; }
    public int? DeceasedToDate { get; set; }
}