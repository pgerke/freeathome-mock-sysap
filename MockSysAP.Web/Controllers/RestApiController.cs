using Microsoft.AspNetCore.Mvc;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Models;
using PhilipGerke.FreeAtHome.MockSysAP.Web.Services;
using System.Net.Mime;

namespace PhilipGerke.FreeAtHome.MockSysAP.Web.Controllers
{
    /// <summary>
    /// The controller for the REST API.
    /// </summary>
    [ApiController]
    [Route("fhapi/v1/api/rest")]
    public sealed class RestApiController : Controller
    {
        private readonly ISystemAccessPointService<SystemAccessPoint> sysApService;

        /// <summary>
        /// Constructs a new <see cref="RestApiController"/> instance injecting the specified services.
        /// </summary>
        /// <param name="sysApService">The System Access Point service instance.</param>
        public RestApiController(ISystemAccessPointService<SystemAccessPoint> sysApService)
        { this.sysApService = sysApService; }

        /// <summary>
        /// Get the System Access Point configuration.
        /// </summary>
        [HttpGet("configuration")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(SystemAccessPoint), 200)]
        [ProducesResponseType(401)]
        public IActionResult GetConfiguration() { return new JsonResult(sysApService.Configuration); }

        /// <summary>
        /// Get the device list.
        /// </summary>
        [HttpGet("devicelist")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public IActionResult GetDeviceList() { return new JsonResult(sysApService.DeviceList); }

        /// <summary>
        /// Gets the specified device.
        /// </summary>
        /// <param name="sysAp">The System Access Point identifier.</param>
        /// <param name="device">The device serial.</param>
        [HttpGet("device/{sysAp}/{device}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public IActionResult GetDevice([FromRoute] Guid sysAp, [FromRoute] string device)
        {
            IDevice? resolvedDevice = sysApService.GetDevice(sysAp, device);
            return (resolvedDevice == null) ? NotFound() : (new JsonResult(resolvedDevice));
        }

        /// <summary>
        /// Gets the device datapoint.
        /// </summary>
        /// <param name="sysAp">The System Access Point identifier.</param>
        /// <param name="device">The device serial.</param>
        /// <param name="channel">The device channel</param>
        /// <param name="datapoint">The data point.</param>
        /// <returns></returns>
        [HttpGet("datapoint/{sysAp}/{device}/{channel}/{datapoint}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        public IActionResult GetDataPointValue(
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
        public IActionResult SetDataPointValue(
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
