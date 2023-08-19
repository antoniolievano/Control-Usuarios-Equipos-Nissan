using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class Usuario_Correos
    {
        public int IdUsuario { get; set; }
        public int NumeroCorreo { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_ÁÉÍÓÚáéíóú]+([-+.'][a-zA-Z0-9_ÁÉÍÓÚáéíóú]+)*@[a-zA-Z0-9_]+[.][A-Za-z]+([.][A-Za-z]+)?$")]
        [Required(ErrorMessage = "No se acepta campos vacíos")]
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}
