using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastsController : ControllerBase
{

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakFast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakFast(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }


    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakFast(Guid id)
    {
        return Ok(id);
    }
}