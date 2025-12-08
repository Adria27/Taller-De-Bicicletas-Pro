using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Interfaces.Services
{
    public interface IBicicletaService
    {
        Task<List<Bicicleta>> GetAllAsync();
        Task<Bicicleta?> GetByIdAsync(int id);
        Task AddAsync(Bicicleta entity);
        Task UpdateAsync(Bicicleta entity);
        Task DeleteAsync(int id);
    }
}

