using TallerDeBicicletasPro.Application.Interfaces.Repositories;
using TallerDeBicicletasPro.Domain.Entities;
using TallerDeBicicletasPro.Persistence.Context;

namespace TallerDeBicicletasPro.Persistence.Repositories
{
    public class BicicletaRepository : GenericRepository<Bicicleta>, IBicicletaRepository
    {
        public BicicletaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
