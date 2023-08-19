using System;
using System.Collections.Generic;

#nullable disable

namespace ControlUsuariosEquipos.Wasm.Shared
{
    public class Sucursal
    {
        public Sucursal()
        {
            
        }

        public int Id { get; set; }
        public int IdAgencia { get; set; }
        public string Nombre { get; set; }
    }
}
