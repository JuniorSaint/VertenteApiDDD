using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Dtos.ProductType;
using Api.Domain.Interfaces.Services;


namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private IProductTypeService _service { get; set; }
        public ProductTypesController(IProductTypeService service)
        {
            _service = service;
        }


        //  [Authorize("Bearer")]
        [HttpGet]
        [Route("{id:guid}", Name = "GetProductTypeWithId")]
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


        //    [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProductTypeUpdateDto entries)
        {
            try
            {
                var result = await _service.Put(entries);
                if (result == null)
                {
                    return BadRequest("Dados não foram atualizados");
                }
                return Ok(result);

            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //     [Authorize("Bearer")]
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

        //     [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductTypeCreateDto entries)
        {
            try
            {
                var result = await _service.Post(entries);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetProductTypeWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest("Erro no envio do corpo do Post");
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        //    [Authorize("Bearer")]
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
