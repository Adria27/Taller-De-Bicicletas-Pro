using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Interfaces.Services
{
    public interface IMecanicoService
    {
        Task<List<Mecanico>> GetAllAsync();
        Task<Mecanico?> GetByIdAsync(int id);
        Task AddAsync(Mecanico entity);
        Task UpdateAsync(Mecanico entity);
        Task DeleteAsync(int id);
    }
}

