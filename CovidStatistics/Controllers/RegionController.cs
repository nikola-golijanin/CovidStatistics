using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared;

namespace CovidStatistics.Controllers;


[Route("api/[controller]")]
[ApiController]
public class RegionController : ControllerBase
{
    private readonly IRegionService _regionService;
    public RegionController(IRegionService regionService)
    {
        _regionService = regionService;
    }
    
    [HttpGet("cases")]
    public IActionResult GetCases([FromQuery] RequestParameters requestParameters)
    {
        var cases =_regionService.GetRegionCases(requestParameters);
        return Ok(cases);
    }
}