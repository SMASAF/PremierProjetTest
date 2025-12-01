using Microsoft.AspNetCore.Mvc;
using PremierProjetTest.Entities;

namespace PremierProjetTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoitureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Safouane", "SMA",
        };

        private readonly ILogger<VoitureController> _logger;

        public VoitureController(ILogger<VoitureController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVoiture")]
        public IEnumerable<string> Get()
        {
            return Summaries.ToArray();
        }
    }
}
