using System.Collections;
using APIOgVueAvslutning.Models;
using APIOgVueAvslutning.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIOgVueAvslutning.Controllers
{
    [ApiController]
    [Route("api/coockies")]
    public class CoockiesController : ControllerBase
    {

        private readonly ICoockiesInfo _coockiesInfo;

        public CoockiesController(ICoockiesInfo coockiesInfo)
        {
            _coockiesInfo = coockiesInfo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coockies>>> GetCoockies()
        {
            var temp= await _coockiesInfo.GetCoockies();
            return Ok(temp);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCoockieById(int id)
        {
            var temp = await _coockiesInfo.getCoockieById(id);
            return Ok(temp);
        }

       
    }
}
