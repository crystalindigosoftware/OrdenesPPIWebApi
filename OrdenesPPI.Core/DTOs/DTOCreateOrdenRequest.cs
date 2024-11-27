using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.DTOs
{
    public class DTOCreateOrdenRequest
    {
        public int CuentaId { get; set; }
        public int ActivoId { get; set; }
        public string Operacion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
    }
}
