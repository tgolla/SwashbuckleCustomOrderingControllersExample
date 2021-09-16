using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SwashbuckleCustomOrderingControllersExample.Controllers
{
    [ApiController]
    [Route("theater/[controller]")]
    [SwaggerControllerOrder(1)]
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

        [HttpOptions("optionsExample")]
        public IActionResult OptionsExample()
        {
            return Ok();
        }

        [HttpPut("putExample")]
        public IActionResult PutExample()
        {
            return Ok();
        }
        [HttpDelete("deleteExample")]
        public IActionResult DeleteExample()
        {
            return Ok();
        }

        [HttpPost("postExample")]
        public IActionResult PostExample()
        {
            return Ok();
        }

        /// <summary>
        /// Dummy call to show example of hidden item.
        /// </summary>
        /// <returns></returns>
        [HttpGet("something")]
        [ApiExplorerSettings(GroupName = "Hidden")]
        public IActionResult GetSomethingElse()
        {
            return Ok(new { something = "Anything" });
        }
    }
}
