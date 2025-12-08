using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Services
{
    public class ReparacionService : IReparacionService
    {
        private readonly IReparacionRepository _repository;

        public ReparacionService(IReparacionRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Reparacion>> GetAllAsync()
            => _repository.GetAllAsync();

        public Task<Reparacion?> GetByIdAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task AddAsync(Reparacion entity)
            => _repository.AddAsync(entity);

        public Task UpdateAsync(Reparacion entity)
            => _repository.UpdateAsync(entity);

        public Task DeleteAsync(int id)
            => _repository.DeleteAsync(id);
    }
}
