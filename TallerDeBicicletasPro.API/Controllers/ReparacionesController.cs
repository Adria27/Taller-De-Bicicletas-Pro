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
    public class ReparacionesController : ControllerBase
    {
        private readonly IReparacionService _service;
        private readonly IMapper _mapper;

        public ReparacionesController(IReparacionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _service.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<ReparacionDto>>(entities);
            return Ok(dtos);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            var dto = _mapper.Map<ReparacionDto>(entity);
            return Ok(dto);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(ReparacionDto dto)
        {
            var entity = _mapper.Map<Reparacion>(dto);

            await _service.AddAsync(entity);

            var resultDto = _mapper.Map<ReparacionDto>(entity);
            return Ok(resultDto);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ReparacionDto dto)
        {
            dto.Id = id;

            var entity = _mapper.Map<Reparacion>(dto);

            await _service.UpdateAsync(entity);

            var resultDto = _mapper.Map<ReparacionDto>(entity);
            return Ok(resultDto);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return Ok("Eliminado correctamente");
        }
    }
}
