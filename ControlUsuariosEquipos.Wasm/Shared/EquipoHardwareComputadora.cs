using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class EquipoHardwareComputadora
    {
        public EquipoHardwareComputadora()
        {

        }
        public int IdEquipo { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Procesador { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        [Required(ErrorMessage = "{0} es requerido")]
        public int Ram { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        [Required(ErrorMessage = "{0} es requerido")]
        public int DiscoDuro { get; set; }
        public bool Ssd { get; set; }
    }
}
