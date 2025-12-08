using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Cliente>> GetAllAsync()
            => _repository.GetAllAsync();

        public Task<Cliente?> GetByIdAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task AddAsync(Cliente entity)
            => _repository.AddAsync(entity);

        public Task UpdateAsync(Cliente entity)
            => _repository.UpdateAsync(entity);

        public Task DeleteAsync(int id)
            => _repository.DeleteAsync(id);
    }
}
