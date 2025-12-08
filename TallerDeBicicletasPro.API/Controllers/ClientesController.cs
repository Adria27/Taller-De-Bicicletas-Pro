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
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;

        public ClientesController(IClienteService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _service.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<ClienteDto>>(entities);
            return Ok(dtos);
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            var dto = _mapper.Map<ClienteDto>(entity);
            return Ok(dto);
        }

        // POST: api/Clientes
        [HttpPost]
        public async Task<IActionResult> Create(ClienteDto dto)
        {
            var entity = _mapper.Map<Cliente>(dto);

            await _service.AddAsync(entity);

            var resultDto = _mapper.Map<ClienteDto>(entity);
            return Ok(resultDto);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClienteDto dto)
        {
            dto.Id = id;

            var entity = _mapper.Map<Cliente>(dto);

            await _service.UpdateAsync(entity);

            var resultDto = _mapper.Map<ClienteDto>(entity);
            return Ok(resultDto);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return Ok("Eliminado correctamente");
        }
    }
}
