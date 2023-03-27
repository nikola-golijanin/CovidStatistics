using Entities.Enums;

namespace Shared;

public class RequestParameters
{
    public Region Region { get; set; }
    
    public DateTime FromDate { get; set; }
    
    public DateTime ToDate { get; set; }
}