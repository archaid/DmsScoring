using Microsoft.AspNetCore.Mvc;
using DmsScoring.Models;
using DmsScoring.Services;

namespace DmsScoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoringController : ControllerBase
    {
        private readonly IScoringService _service;

        public ScoringController(IScoringService service)
        {
            _service = service;
        }

        [HttpGet("default-rows")]
        public IActionResult GetDefaultRows()
        {
            return Ok(DefaultScoringData.GetRows());
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] ScoringRequest request)
        {
            if (request == null || request.Rows == null || !request.Rows.Any())
                return BadRequest("Rows cannot be empty.");

            var result = _service.Calculate(request);
            return Ok(result);
        }
    }

}
