using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Entities
{
    public class Estado
    {
        public Estado() { 
            Ordenes = new Collection<Orden>();
        }
        public int Id { get; set; }

        public string descripcionEstado { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
    }
}
