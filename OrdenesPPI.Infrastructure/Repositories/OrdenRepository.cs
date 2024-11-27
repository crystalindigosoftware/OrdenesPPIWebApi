using Microsoft.EntityFrameworkCore;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Views;
using OrdenesPPI.Core.Interfaces.Repository;
using OrdenesPPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Infrastructure.Repositories
{
    public class OrdenRepository : BaseRepository<Orden>, IOrdenRepository
    {
        public OrdenRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<V_Ordenes>> GetAllOrdenes()
        {
            return await Context.V_Ordenes.ToListAsync();
            
        }

        public async ValueTask<V_Ordenes> GetOrdenesById(int Id) {
            return await Context.V_Ordenes.FindAsync(Id);
        }
    }
}
