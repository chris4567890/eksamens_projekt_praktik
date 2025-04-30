using eksamn_project.Server.Models;
using Microsoft.AspNetCore.Mvc;
namespace eksamn_project.Server.Controllers
{
    [ApiController]
    [Route("api/barsel")]
    public class BarselsController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] BarselModel model)
        {
            var result = BarselsService.CalculateAmountOfBarsel(model);
            return Ok(new { calculatedBarsel = result});
        }
    }
}
