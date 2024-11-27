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
    public class EstadoService : IEstadoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstadoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Estado>> GetAll()
        {
            return await _unitOfWork.EstadoRepository.GetAllAsync();
        }
    }
}
