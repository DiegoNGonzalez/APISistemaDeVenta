using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{
    public class SesionDTO
    {
        public int IdUsuario { get; set; }

        public string? NombreApellido { get; set; }

        public string? Email { get; set; }

        public string? RolDescripcion { get; set; }


    }
}
