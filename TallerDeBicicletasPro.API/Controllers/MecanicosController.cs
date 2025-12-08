using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MecanicosController : ControllerBase
    {
        private readonly IMecanicoService _service;

        public MecanicosController(IMecanicoService service)
        {
            _service = service;
        }

        // GET: api/Mecanicos
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // GET: api/Mecanicos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // POST: api/Mecanicos
        [HttpPost]
        public async Task<IActionResult> Create(Mecanico mecanico)
        {
            await _service.AddAsync(mecanico);
            return Ok(mecanico);
        }

        // PUT: api/Mecanicos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Mecanico mecanico)
        {
            mecanico.Id = id;
            await _service.UpdateAsync(mecanico);
            return Ok(mecanico);
        }

        // DELETE: api/Mecanicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Eliminado correctamente");
        }
    }
}
