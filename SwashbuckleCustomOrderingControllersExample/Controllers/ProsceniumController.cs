using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SwashbuckleCustomOrderingControllersExample.Controllers
{
    [ApiController]
    [Route("theater/[controller]")]
    public class ProsceniumController : ControllerBase
    {
        private readonly ILogger<ProsceniumController> logger;

        /// <summary>
        /// Proscenium controller constructor.
        /// </summary>
        /// <param name="logger">A generic interface for logging where the category name is derived from the specified TCategoryName type name used to enable activation of a named ILogger from dependency injection.</param>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        public ProsceniumController(ILogger<ProsceniumController> logger, IConfiguration configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Get information about the theater type.
        /// </summary>
        /// <returns>Information about the theater type.</returns>
        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            return Ok(new { type = "Proscenium" });
        }
    }
}
