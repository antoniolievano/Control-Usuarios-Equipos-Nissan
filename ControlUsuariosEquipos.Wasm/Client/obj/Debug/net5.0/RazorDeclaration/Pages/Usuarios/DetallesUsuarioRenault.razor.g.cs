// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ControlUsuariosEquipos.Wasm.Client.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using ControlUsuariosEquipos.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using ControlUsuariosEquipos.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using ControlUsuariosEquipos.Wasm.Client.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using ControlUsuariosEquipos.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class DetallesUsuarioRenault : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\DetallesUsuarioRenault.razor"
       
    public Usuario_Sia_Renault usuarioRenault = new Usuario_Sia_Renault();

    [CascadingParameter]
    MudDialogInstance MudDialog { get; set; }

    private void Cancelar()
    {
        MudDialog.Cancel();
    }

    private void AgregarUsuarioRenault()
    {
        if (string.IsNullOrEmpty(usuarioRenault.Usuario.Trim()) || string.IsNullOrEmpty(usuarioRenault.Ubicacion.Trim()))
        {
            Snackbar.Add("Por favor, ingresa valor para uno o ambos campos vacíos.", Severity.Success, a => a.VisibleStateDuration = 500);
        }
        else
        {
            MudDialog.Close(DialogResult.Ok(usuarioRenault));
            Snackbar.Add("Usuario Sia Renault agregado", Severity.Success, a => a.VisibleStateDuration = 200);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario ServicioUsuario { get; set; }
    }
}
#pragma warning restore 1591
