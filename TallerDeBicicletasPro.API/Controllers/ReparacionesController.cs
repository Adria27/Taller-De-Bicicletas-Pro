using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReparacionesController : ControllerBase
    {
        private readonly IReparacionService _service;

        public ReparacionesController(IReparacionService service)
        {
            _service = service;
        }

        // GET: api/Reparaciones
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // GET: api/Reparaciones/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // POST: api/Reparaciones
        [HttpPost]
        public async Task<IActionResult> Create(Reparacion reparacion)
        {
            await _service.AddAsync(reparacion);
            return Ok(reparacion);
        }

        // PUT: api/Reparaciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Reparacion reparacion)
        {
            reparacion.Id = id;
            await _service.UpdateAsync(reparacion);
            return Ok(reparacion);
        }

        // DELETE: api/Reparaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Eliminado correctamente");
        }
    }
}
