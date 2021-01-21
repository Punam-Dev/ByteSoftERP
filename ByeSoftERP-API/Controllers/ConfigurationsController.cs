using ByeSoftERP_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        private readonly IConfigurationRepository configurationRepository;
        public ConfigurationsController(IConfigurationRepository configurationRepository)
        {
            this.configurationRepository = configurationRepository;
        }
        [HttpGet("{TableName}")]
        public async Task<IActionResult> Get(string TableName)
        {
            try
            {
                if (TableName.ToUpper() == "PRODUCTTYPES")
                {
                    return Ok(await configurationRepository.GetProductTypes());
                }
                else if (TableName.ToUpper() == "UOM")
                {
                    return Ok(await configurationRepository.GetUOMs());
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }
    }
}
