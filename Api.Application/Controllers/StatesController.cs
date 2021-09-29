using System;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private IStateService _service { get; set; }
        public StatesController(IStateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var result = await _service.GetAll();
                if (result == null)
                {
                    return NotFound("Nenhum dado foi encontrado");
                }
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

