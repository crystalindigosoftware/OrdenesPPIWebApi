using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Entities
{
    public class Orden
    {
        public int Id { get; set; }
        public int CuentaId { get; set; }

        public Cuenta Cuenta { get; set; }

        public int ActivoId { get; set; }

        public Activo Activo { get; set; }

        public int EstadoId { get; set; }

        public Estado Estado { get; set; }
        public string Operacion { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Comisiones { get; set; }

        public decimal Impuestos { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
