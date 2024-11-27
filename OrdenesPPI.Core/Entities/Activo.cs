using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Entities
{
    public class Activo
    {
        public Activo() {
            Ordenes = new Collection<Orden>();
        }

        public int Id { get; set; }

        public string Ticker { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int TipoActivoId { get; set; }
        public Tipoactivo Tipoactivo { get; set; }

        public ICollection<Orden> Ordenes { get; set; }

    }
}
