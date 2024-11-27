using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesPPI.Core.Views;

namespace OrdenesPPI.Core.Interfaces.Services
{
    public interface IOrdenService
    {
        
        Task<DTOCreateOrdenResponse> CreateOrden(DTOCreateOrdenRequest newOrden);
        Task<DTOUpdateOrdenResponse> UpdateOrden(DTOUpdateOrdenRequest newOrdenValues);
        Task DeleteOrden(int OrdenId);
        Task<V_Ordenes> GetOrdenesById(int id);
        Task<IEnumerable<V_Ordenes>> GetAllOrdenes();
    }
}
