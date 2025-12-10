// TallerDeBicicletasPro.API/Controllers/BicicletasController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TallerDeBicicletasPro.Application.DTOs;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BicicletasController : ControllerBase
    {
        private readonly IBicicletaService _service;
        private readonly IMapper _mapper;

        public BicicletasController(IBicicletaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Bicicletas
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _service.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<BicicletaDto>>(entities);
            return Ok(dtos);
        }

        // GET: api/Bicicletas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            var dto = _mapper.Map<BicicletaDto>(entity);
            return Ok(dto);
        }

        // POST: api/Bicicletas
        [HttpPost]
        public async Task<IActionResult> Create(BicicletaDto dto)
        {
            var entity = _mapper.Map<Bicicleta>(dto);
            await _service.AddAsync(entity);

            var resultDto = _mapper.Map<BicicletaDto>(entity);
            return Ok(resultDto);
        }

        // PUT: api/Bicicletas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BicicletaDto dto)
        {
            dto.Id = id;
            var entity = _mapper.Map<Bicicleta>(dto);

            await _service.UpdateAsync(entity);

            var resultDto = _mapper.Map<BicicletaDto>(entity);
            return Ok(resultDto);
        }

        // DELETE: api/Bicicletas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // No importa si DeleteAsync devuelve Task o Task<bool>, ignoramos el valor
            await _service.DeleteAsync(id);
            return Ok("Eliminado correctamente");
        }
    }
}
