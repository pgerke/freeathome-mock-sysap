using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Mime;
using System.Text.Json;

namespace MockSysAP.Web.Controllers
{
    [ApiController]
    [Route("fhapi/v1/api/rest")]
    public sealed class RestApiController : Controller
    {
        private readonly ILogger logger;
        private readonly object? configuration;

        public RestApiController(ILogger<RestApiController> logger)
        {
            this.logger = logger;
            logger.Log(LogLevel.Debug, Directory.GetCurrentDirectory());

            using(StreamReader stream = System.IO.File
                .OpenText(Path.Join(Directory.GetCurrentDirectory(), "data", "configuration.json")))
            {
                configuration = JsonSerializer.Deserialize(stream.ReadToEnd(), typeof(object));
            }
        }


        /// <summary>
        /// Get the System Access Point configuration.
        /// </summary>
        [HttpGet("configuration")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public IActionResult GetConfiguration() { return Json(configuration); }

        /// <summary>
        /// Get the device list.
        /// </summary>
        [HttpGet("devicelist")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public IActionResult GetDeviceList() { return Ok("Get Device List"); }

        [HttpGet("device/{sysAp}/{device}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public IActionResult GetDevice([FromRoute] string sysAp, [FromRoute] string device)
        { return Ok($"Get Device: SysAP '{sysAp}', Device Serial '{device}'"); }

        [HttpGet("datapoint/{sysAp}/{device}/{channel}/{datapoint}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public IActionResult GetDatapointValue(
            [FromRoute] string sysAp,
            [FromRoute] string device,
            [FromRoute] string channel,
            [FromRoute] string datapoint)
        {
            return Ok(
                $"Get Datapoint Value: SysAP '{sysAp}', Device Serial '{device}', Channel '{channel}', Datapoint '{datapoint}'");
        }

        [HttpPut("datapoint/{sysAp}/{device}/{channel}/{datapoint}")]
        [Consumes(MediaTypeNames.Text.Plain)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(502)]
        public IActionResult SetDatapointValue(
            [FromRoute] string sysAp,
            [FromRoute] string device,
            [FromRoute] string channel,
            [FromRoute] string datapoint)
        {
            return Ok(
                $"Set Datapoint Value: SysAP '{sysAp}', Device Serial '{device}', Channel '{channel}', Datapoint '{datapoint}'");
        }

        [HttpPut("virtualdevice/{sysAp}/{serial}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(502)]
        public IActionResult CreateVirtualDevice([FromRoute] string sysAp, [FromRoute] string serial)
        { return StatusCode(500, "Not implemented"); }
    }
}
