using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Entities
{
    public class Cuenta
    {
        public Cuenta() {
            Ordenes = new Collection<Orden>();
        }
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
    }
}
