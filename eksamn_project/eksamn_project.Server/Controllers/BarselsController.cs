using eksamn_project.Server.Models;
using Microsoft.AspNetCore.Mvc;
using eksamn_project.Server.Services;
using eksamn_project.Server.Helpers;
using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;
namespace eksamn_project.Server.Controllers
{
    [ApiController]
    [Route("api/barsel")]
    public class BarselsController : Controller
    {
        private readonly OverenskomstService _overenskomstService;

        public BarselsController(OverenskomstService overenskomstService)
        {
            _overenskomstService = overenskomstService;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BarselModel model)
        {

            //var overenskomst = await _overenskomstService.GetOvernsKomstByNameAndGender(model.RelationshipStatus);
            var overenkomst = await _overenskomstService.GetOvernsKomstByName(model.OverEnskomst);
            BarselsHelper barselsHelper = new BarselsHelper();
            BarselsService barselsService = new BarselsService(barselsHelper,overenkomst);
            var result = barselsService.CalculateAmountOfBarsel(model);
            return Ok(new { calculatedBarsel = result});
        }
    }
}
