using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class Usuario_Sia_Renault
    {
        public int IdUsuario { get; set; }
        public int NumeroCuenta { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Ubicacion { get; set; }
    }
}
