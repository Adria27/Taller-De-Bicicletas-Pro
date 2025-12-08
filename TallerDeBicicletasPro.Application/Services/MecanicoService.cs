using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Services
{
    public class MecanicoService : IMecanicoService
    {
        private readonly IMecanicoRepository _repository;

        public MecanicoService(IMecanicoRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Mecanico>> GetAllAsync()
            => _repository.GetAllAsync();

        public Task<Mecanico?> GetByIdAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task AddAsync(Mecanico entity)
            => _repository.AddAsync(entity);

        public Task UpdateAsync(Mecanico entity)
            => _repository.UpdateAsync(entity);

        public Task DeleteAsync(int id)
            => _repository.DeleteAsync(id);
    }
}
