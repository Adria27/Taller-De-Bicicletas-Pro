using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Application.DTOs;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MecanicosController : ControllerBase
    {
        private readonly IMecanicoService _service;
        private readonly IMapper _mapper;

        public MecanicosController(IMecanicoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Mecanicos
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _service.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<MecanicoDto>>(entities);
            return Ok(dtos);
        }

        // GET: api/Mecanicos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            var dto = _mapper.Map<MecanicoDto>(entity);
            return Ok(dto);
        }

        // POST: api/Mecanicos
        [HttpPost]
        public async Task<IActionResult> Create(MecanicoDto dto)
        {
            var entity = _mapper.Map<Mecanico>(dto);

            await _service.AddAsync(entity);

            var resultDto = _mapper.Map<MecanicoDto>(entity);
            return Ok(resultDto);
        }

        // PUT: api/Mecanicos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MecanicoDto dto)
        {
            dto.Id = id;

            var entity = _mapper.Map<Mecanico>(dto);

            await _service.UpdateAsync(entity);

            var resultDto = _mapper.Map<MecanicoDto>(entity);
            return Ok(resultDto);
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
