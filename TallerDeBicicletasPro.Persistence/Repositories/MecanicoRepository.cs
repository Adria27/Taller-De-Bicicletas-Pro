using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Domain.Entities;
using TallerDeBicicletasPro.Persistence.Context;

namespace TallerDeBicicletasPro.Persistence.Repositories
{
    public class MecanicoRepository : GenericRepository<Mecanico>, IMecanicoRepository
    {
        public MecanicoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
