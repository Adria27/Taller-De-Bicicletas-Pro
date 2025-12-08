using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Application.Interfaces.Services;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Services
{
    public class BicicletaService : IBicicletaService
    {
        private readonly IBicicletaRepository _repository;

        public BicicletaService(IBicicletaRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Bicicleta>> GetAllAsync()
            => _repository.GetAllAsync();

        public Task<Bicicleta?> GetByIdAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task AddAsync(Bicicleta entity)
            => _repository.AddAsync(entity);

        public Task UpdateAsync(Bicicleta entity)
            => _repository.UpdateAsync(entity);

        public Task DeleteAsync(int id)
            => _repository.DeleteAsync(id);
    }
}
