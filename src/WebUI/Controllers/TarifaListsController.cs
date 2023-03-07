using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ntitsolutions.Application.Tarifas.Queries.GetTarifas;

namespace WebUI.Controllers;

[Authorize]
public class TarifaListsController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<TarifaDto>>> Get()
    {
        return await Mediator.Send(new GetTarifasQuery());
    }
}
