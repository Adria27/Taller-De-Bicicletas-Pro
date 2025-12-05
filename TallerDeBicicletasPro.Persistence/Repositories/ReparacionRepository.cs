using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Domain.Entities;
using TallerDeBicicletasPro.Persistence.Context;

namespace TallerDeBicicletasPro.Persistence.Repositories
{
    public class ReparacionRepository : GenericRepository<Reparacion>, IReparacionRepository
    {
        public ReparacionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
