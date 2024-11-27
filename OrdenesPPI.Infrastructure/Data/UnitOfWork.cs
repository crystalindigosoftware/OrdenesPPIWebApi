using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesPPI.Core.Interfaces;
using OrdenesPPI.Core.Interfaces.Repository;
using OrdenesPPI.Infrastructure.Repositories;

namespace OrdenesPPI.Infrastructure.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        private TipoactivoRepository _tipoactivoRepository;
        private ActivoRepository _activoRepository;
        private EstadoRepository _estadoRepository;
        private CuentaRepository _cuentaRepository;
        private OrdenRepository _ordenRepository;

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
        }

        public ITipoactivoRepository TipoactivoRepository => _tipoactivoRepository ??= new TipoactivoRepository(_context);

        public IActivoRepository ActivoRepository => _activoRepository ??= new ActivoRepository(_context);

        public IEstadoRepository EstadoRepository => _estadoRepository ??= new EstadoRepository(_context);

        public ICuentaRepository CuentaRepository => _cuentaRepository ??= new CuentaRepository(_context);

        public IOrdenRepository OrdenRepository => _ordenRepository ??= new OrdenRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
