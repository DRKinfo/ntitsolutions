using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ntitsolutions.Application.Common.Models;
using ntitsolutions.Application.Planos.Queries.GetPlanosWithPagination;

namespace WebUI.Controllers;

[Authorize]
public class PlanosController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<PaginatedList<PlanoDto>>> GetTodoItemsWithPagination([FromQuery] GetPlanosWithPaginationQuery query)
    {
        return await Mediator.Send(query);
    }
}
