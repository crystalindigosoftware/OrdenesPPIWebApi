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
    public class CuentaService : ICuentaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CuentaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Cuenta>> GetAll()
        {
            return await _unitOfWork.CuentaRepository.GetAllAsync();
        }
    }
}
