using System.Collections.Generic;
using System.Threading.Tasks;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Interfaces.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAllAsync();
        Task<Cliente?> GetByIdAsync(int id);
        Task AddAsync(Cliente entity);
        Task UpdateAsync(Cliente entity);
        Task DeleteAsync(int id);
    }
}
