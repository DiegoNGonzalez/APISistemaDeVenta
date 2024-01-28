using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string? NombreApellido { get; set; }

        public string? Email { get; set; }

        public int? IdRol { get; set; }
        public string? RolDescripcion { get; set; }

        public string? Clave { get; set; }

        public int? EsActivo { get; set; }
    }
}
