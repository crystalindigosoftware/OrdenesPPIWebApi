using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Core.Entities
{
    public class Tipoactivo
    {
        public Tipoactivo() { 
            Activos = new Collection<Activo>();
        }
        public int Id { get; set; }

        public string Descripcion {  get; set; }

        public ICollection<Activo> Activos { get; set; }

    }
}
