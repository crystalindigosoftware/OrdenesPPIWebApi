using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Interfaces;
using OrdenesPPI.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Services
{
    public class ActivoService : IActivoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActivoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Activo>> GetAll()
        {
            return await _unitOfWork.ActivoRepository.GetAllAsync();
        }

        public async Task<Activo> GetActivoById(int id)
        {
            return await _unitOfWork.ActivoRepository.GetByIdAsync(id);
        }
    }
}
