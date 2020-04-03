using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BorangBantuanCovid19.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntriesController : ControllerBase
    {
        [HttpGet("api/[controller]")]
        public async Task<ActionResult> GetAll()
        {

            return Ok();
        }
    }
}