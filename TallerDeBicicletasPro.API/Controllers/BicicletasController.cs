using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BicicletasController : ControllerBase
    {
        private readonly IBicicletaService _bicicletaService;

        public BicicletasController(IBicicletaService bicicletaService)
        {
            _bicicletaService = bicicletaService;
        }

        // GET: api/Bicicletas
        [HttpGet]
        public async Task<ActionResult<List<Bicicleta>>> Get()
        {
            var bicicletas = await _bicicletaService.GetAllAsync();
            return Ok(bicicletas);
        }

        // GET: api/Bicicletas/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Bicicleta>> GetById(int id)
        {
            var bicicleta = await _bicicletaService.GetByIdAsync(id);

            if (bicicleta == null)
                return NotFound();

            return Ok(bicicleta);
        }

        // POST: api/Bicicletas
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Bicicleta bicicleta)
        {
            if (bicicleta == null)
                return BadRequest();

            await _bicicletaService.AddAsync(bicicleta);

            // Por ahora devolvemos solo Ok. Más adelante
            // podemos mejorar a CreatedAtAction si quieres.
            return Ok();
        }

        // PUT: api/Bicicletas/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] Bicicleta bicicleta)
        {
            if (bicicleta == null)
                return BadRequest();

            // Si tu entidad tiene propiedad Id, puedes validar aquí:
            // if (id != bicicleta.Id) return BadRequest();

            await _bicicletaService.UpdateAsync(bicicleta);

            return NoContent();
        }

        // DELETE: api/Bicicletas/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bicicletaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
