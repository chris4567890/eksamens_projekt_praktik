using eksamn_project.Server.Models;
using eksamn_project.Server.Models.DTOs;
using eksamn_project.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace eksamn_project.Server.Controllers
{
    [ApiController]
    [Route("api/overnskomst")]
    public class OvernskomstController : Controller
    {
        private readonly OverenskomstService _overenskomstService;
        private GenderDTO _genderDTO;
        public OvernskomstController(OverenskomstService service, GenderDTO genderDTO) 
        { 
            _overenskomstService = service;
            _genderDTO = genderDTO;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GenderDTO dTO)
        {
            if(dTO == null)
            {
                return BadRequest("invalidt dto");
            }

            var overnskomst = await _overenskomstService.GetOverenskomstByGender(dTO.Gender);
            
            return Ok(overnskomst);
        }
    }
}
