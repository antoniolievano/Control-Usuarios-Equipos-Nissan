using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class EquipoSoftwareComputadora
    {
        public EquipoSoftwareComputadora()
        {

        }
        public int IdEquipo { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string SistemaOperativo { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        [Required(ErrorMessage = "{0} es requerido")]
        public int VersionOffice { get; set; }
    }
}
