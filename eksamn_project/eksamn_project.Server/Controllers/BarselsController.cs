using eksamn_project.Server.Models;
using Microsoft.AspNetCore.Mvc;
using eksamn_project.Server.Services;
using eksamn_project.Server.Helpers;
namespace eksamn_project.Server.Controllers
{
    [ApiController]
    [Route("api/barsel")]
    public class BarselsController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] BarselModel model)
        {
            BarselsHelper barselsHelper = new BarselsHelper();
            BarselsService barselsService = new BarselsService(barselsHelper);
            var result = barselsService.CalculateAmountOfBarsel(model);
            return Ok(new { calculatedBarsel = result});
        }
    }
}
