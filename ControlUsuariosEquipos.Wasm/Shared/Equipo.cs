using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class Equipo
    {
        public int Id { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public int IdAgencia { get; set; }
        public int? IdUsuario { get; set; }
        public string Usuario { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Folio { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int HardwarePC { get; set; }
        public int SoftwarePC { get; set; }
        public EquipoHardwareComputadora HardwareComputadora { get; set; }
        public EquipoSoftwareComputadora SoftwareComputadora { get; set; }
        public bool estaEliminando { get; set; } = false;
    }
}
