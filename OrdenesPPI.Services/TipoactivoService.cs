using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Interfaces;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Services
{
    public class TipoactivoService : ITipoactivoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TipoactivoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Tipoactivo>> GetAll()
        {
            return await _unitOfWork.TipoactivoRepository.GetAllAsync();
        }

        public async Task<Tipoactivo> GetTipoActivoById(int id)
        {
            return await _unitOfWork.TipoactivoRepository.GetByIdAsync(id);
        }

    }
}
