using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Interfaces.Repository;
using OrdenesPPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Infrastructure.Repositories
{
    public class ActivoRepository : BaseRepository<Activo>, IActivoRepository
    {
        public ActivoRepository(AppDbContext context) : base(context)
        {

        }
    }
}
