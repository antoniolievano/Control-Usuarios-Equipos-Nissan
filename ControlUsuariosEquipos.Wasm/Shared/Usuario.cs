using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public int IdAgencia { get; set; }
        public string Agencia { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Puesto { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int TotalCorreos { get; set; }
        public int TotalUsuariosChesa { get; set; }
        public int TotalUsuariosRenault { get; set; }

        // Atributos externos que hacen alusión al maestro 'Usuario'
        public List<Usuario_Correos> Correos { get; set; }
        public List<Usuario_Sia_Chesa> UsuariosChesa { get; set; }
        public List<Usuario_Sia_Renault> UsuariosRenault { get; set; }

    }
}
