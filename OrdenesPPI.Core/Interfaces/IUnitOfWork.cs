using OrdenesPPI.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoactivoRepository TipoactivoRepository { get; }

        IActivoRepository ActivoRepository { get; }

        IEstadoRepository EstadoRepository { get; }

        ICuentaRepository CuentaRepository { get; }

        IOrdenRepository OrdenRepository { get; }

        Task<int> CommitAsync();
    }
}
