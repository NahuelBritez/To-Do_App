using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime Recordatorio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCompletado { get; set; }

    }
}
