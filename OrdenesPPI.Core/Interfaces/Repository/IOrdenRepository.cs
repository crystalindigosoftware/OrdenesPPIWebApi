using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Interfaces.Repository
{
    public interface IOrdenRepository : IBaseRepository<Orden>
    {
        Task<IEnumerable<V_Ordenes>> GetAllOrdenes();

        ValueTask<V_Ordenes> GetOrdenesById(int Id);

    }
}
