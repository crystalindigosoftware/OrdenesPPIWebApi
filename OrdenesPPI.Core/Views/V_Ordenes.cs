using OrdenesPPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Views
{
    public class V_Ordenes
    {
        public int IdOrden { get; set; }
        public int IdCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public string NombreActivo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }
        public decimal MontoTotal { get; set; }
        public string Operacion { get; set; }
    }
}
