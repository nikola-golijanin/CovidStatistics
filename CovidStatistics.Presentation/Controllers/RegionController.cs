using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared;

namespace CovidStatistics.Presentation.Controllers;

[Route("api/region")]
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
        var cases = _regionService.GetRegionCases(requestParameters);
        return Ok(cases);
    }

    [HttpGet("lastweek")]
    public IActionResult GetLastWeekStatistics()
    {
        var lastweekCases = _regionService.GetLastweekStatistics();
        return Ok(lastweekCases);
    }
}