using eksamn_project.Server.Models;
using Microsoft.AspNetCore.Mvc;
using eksamn_project.Server.Services;
using eksamn_project.Server.Helpers;
using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
namespace eksamn_project.Server.Controllers
{
    [ApiController]
    [Route("api/barsel")]
    public class BarselsController : Controller
    {
        private readonly IoverenskomstService _overenskomstService;
        private readonly IbarselsService _barselsService;   

        public BarselsController(IoverenskomstService overenskomstService, IbarselsService barselsService)
        {
            _overenskomstService = overenskomstService;
            _barselsService = barselsService;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BarselModel model)
        {
            Console.WriteLine("i am inside the controller");
            try
            {
                var overenkomst = await _overenskomstService.GetOvernsKomstByName(model.OverEnskomst);
                BarselsHelper barselsHelper = new BarselsHelper();

                if (model.OverEnskomst != null && model.OverEnskomst != "")
                {
                    var result = _barselsService.CalculateAmountOfBarselWithOvernskomst(model, overenkomst.MaternityAmountByWeeks);
                    return Ok(new { calculatedBarsel = result });
                }
                else if (model.OverEnskomst == null)
                {
                    var result = _barselsService.CalculateAmountOfBarsel(model);
                    return Ok(new { calculatedBarsel = result });
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex) { 
                Debug.WriteLine(ex);
                return BadRequest();
            }
            
            
                
        }
    }
}
