using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Interfaces.Services
{
    public interface IReparacionService
    {
        Task<List<Reparacion>> GetAllAsync();
        Task<Reparacion?> GetByIdAsync(int id);
        Task AddAsync(Reparacion entity);
        Task UpdateAsync(Reparacion entity);
        Task DeleteAsync(int id);
    }
}
