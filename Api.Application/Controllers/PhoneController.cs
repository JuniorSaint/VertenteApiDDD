using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.Client;
using Api.Domain.Dtos.Phone;
using Api.Domain.Interfaces.Services;
using Api.Domain.MessageException;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private IPhoneService _service { get; set; }
        public PhoneController(IPhoneService service)
        {
            _service = service;
        }

        //[Authorize("Bearer")]
        [HttpGet]
        [Route("{id:guid}", Name = "GetPhoneWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound($"Pesquisa não obteve êxito com Id: {id}");
                }
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //[Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] PhoneDtoUpdate phone)
        {
            try
            {
                var result = await _service.Put(phone);
                if (result == null)
                {
                    return BadRequest("Dados não foram atualizados");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound($"Deleção não obteve êxito com Id: {id}");
                }
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PhoneDtoCreate client)
        {
            try
            {
                var result = await _service.Post(client);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetPhoneWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
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
            catch (Exception)
            {
                throw new MessageException("Erro ao conectar com o banco de dados");
                //return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
