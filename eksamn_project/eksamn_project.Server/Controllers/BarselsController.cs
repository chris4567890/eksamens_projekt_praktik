using eksamn_project.Server.Models;
using Microsoft.AspNetCore.Mvc;
using eksamn_project.Server.Services;
namespace eksamn_project.Server.Controllers
{
    [ApiController]
    [Route("api/barsel")]
    public class BarselsController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] BarselModel model)
        {

            BarselsService barselsService = new BarselsService();
            var result = barselsService.CalculateAmountOfBarsel(model);
            return Ok(new { calculatedBarsel = result});
        }
    }
}
