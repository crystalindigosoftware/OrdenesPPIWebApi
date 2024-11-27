using OrdenesPPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Interfaces.Services
{
    public interface IActivoService
    {
        Task<Activo> GetActivoById(int id);
        Task<IEnumerable<Activo>> GetAll();
    }
}
