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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Detalles_Usuario")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Detalles_Usuario/{id:int}")]
    public partial class DetallesUsuario : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 390 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\DetallesUsuario.razor"
       
    public Usuario usuario;
    List<object> listaUsuario = new List<object>();
    List<object> listaCopiaUsuario = new List<object>();
    private bool cambio;
    private bool usuarioReplicado;
    private bool confirmarGuardar;
    public IEnumerable<Agencia> agencias = new List<Agencia>();
    public IEnumerable<Sucursal> sucursales = new List<Sucursal>();

    [Parameter]
    public int id { get; set; }

    public int correoActual;
    public int usuarioChesaActual;
    public int usuarioRenaultActual;
    public bool renderizar;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (id > 0)
            {
                usuario = await ServicioUsuario.DetallesUsuario(id);

                PropertyInfo[] propiedadesCopiaUsuario = usuario.GetType().GetProperties();

                foreach (var info in propiedadesCopiaUsuario)
                {
                    var valor = info.GetValue(usuario);
                    listaCopiaUsuario.Add(valor);
                }

            }
            else
            {
                usuario = new Usuario() { FechaModificacion = DateTime.Today };
            }

            //El siguiente IEnumerable de agencias se carga con los valores obtenidos del servicio ServicioAgencia
            agencias = await ServicioAgencia.ObtenerAgencias();

            if (agencias != null && agencias.Any())
            {
                usuario.IdAgencia = agencias.FirstOrDefault().Id;

                // Cargar las sucursales en base al Id de la agencia predeterminada
                await CargarSucursales(usuario.IdAgencia);
            }

            renderizar = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error encontrado: " + e.Message);
        }
    }

    protected async Task AgenciaACambiado(int idAgencia)
    {
        usuario.IdAgencia = idAgencia;

        if (usuario.IdAgencia > 0)
            await CargarSucursales(usuario.IdAgencia);
    }

    private async Task CargarSucursales(int idAgencia)
    {
        sucursales = await ServicioSucursal.ObtenerSucursalesPorAgencia(idAgencia);

        if (sucursales != null && sucursales.Any())
        {
            usuario.IdSucursal = sucursales.FirstOrDefault().Id;
        }
    }

    protected async Task AgregarCorreo()
    {
        await Task.Yield();
        var dialog = DialogService.Show<DetallesCorreo>();
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            var correo = (Usuario_Correos)result.Data;

            if (usuario.Correos == null)
            {
                usuario.Correos = new List<Usuario_Correos>();
            }

            if (usuario.Correos != null && usuario.Correos.Any())
            {
                correoActual = usuario.Correos.Count;
            }
            else
            {
                correoActual = 0;
            }

            correoActual++;

            correo.NumeroCorreo = correoActual;

            usuario.Correos.Add(correo);

            cambio = true;
        }
    }

    protected async Task EliminarCorreo(int numeroCorreo)
    {
        await Task.Yield();
        usuario.Correos.RemoveAll(p => p.NumeroCorreo == numeroCorreo);
        correoActual--;
        cambio = true;
        Snackbar.Add("Correo eliminado", Severity.Success, a => a.VisibleStateDuration = 200);
    }

    protected async Task AgregarUsuarioChesa()
    {
        await Task.Yield();
        var dialog = DialogService.Show<DetallesUsuarioChesa>();
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            var usuarioChesa = (Usuario_Sia_Chesa)result.Data;

            if (usuario.UsuariosChesa == null)
            {
                usuario.UsuariosChesa = new List<Usuario_Sia_Chesa>();
            }

            if (usuario.UsuariosChesa != null && usuario.UsuariosChesa.Any())
            {
                usuarioChesaActual = usuario.UsuariosChesa.Count;
            }
            else
            {
                usuarioChesaActual = 0;
            }

            usuarioChesaActual++;

            usuarioChesa.NumeroCuenta = usuarioChesaActual;

            usuario.UsuariosChesa.Add(usuarioChesa);

            cambio = true;
        }
    }

    protected async Task EliminarUsuarioChesa(int numeroCuenta)
    {
        await Task.Yield();
        usuario.UsuariosChesa.RemoveAll(p => p.NumeroCuenta == numeroCuenta);
        usuarioChesaActual--;
        cambio = true;
        Snackbar.Add("Correo eliminado", Severity.Success, a => a.VisibleStateDuration = 200);
    }

    protected async Task AgregarUsuarioRenault()
    {
        await Task.Yield();
        var dialog = DialogService.Show<DetallesUsuarioRenault>();
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            var usuarioRenault = (Usuario_Sia_Renault)result.Data;

            if (usuario.UsuariosRenault == null)
            {
                usuario.UsuariosRenault = new List<Usuario_Sia_Renault>();
            }

            if (usuario.UsuariosRenault != null && usuario.UsuariosRenault.Any())
            {
                usuarioRenaultActual = usuario.UsuariosRenault.Count;
            }
            else
            {
                usuarioRenaultActual = 0;
            }

            usuarioRenaultActual++;

            usuarioRenault.NumeroCuenta = usuarioRenaultActual;

            usuario.UsuariosRenault.Add(usuarioRenault);

            cambio = true;
        }
    }

    protected async Task EliminarUsuarioRenault(int numeroCuenta)
    {
        await Task.Yield();
        usuario.UsuariosRenault.RemoveAll(p => p.NumeroCuenta == numeroCuenta);
        usuarioRenaultActual--;
        cambio = true;
        Snackbar.Add("Correo eliminado", Severity.Success, a => a.VisibleStateDuration = 200);
    }

    protected async Task GuardarUsuario()
    {
        await Task.Yield();
        usuarioReplicado = false;

        if (usuario.Id > 0)
        {
            PropertyInfo[] propiedadesUsuario = usuario.GetType().GetProperties();

            foreach (var info in propiedadesUsuario)
            {
                var valor = info.GetValue(usuario);
                listaUsuario.Add(valor);
            }

            for (int i = 0; i < listaUsuario.Count; i++)
            {
                var valorActual = listaUsuario[i];
                var valorInicial = listaCopiaUsuario[i];
                if (valorActual == null && valorInicial == null)
                {
                    continue;
                }
                else if (!valorActual.Equals(valorInicial))
                {
                    cambio = true;
                    break;
                }
            }

            if (cambio)
            {
                usuario.FechaModificacion = DateTime.Now;
            }
            await ServicioUsuario.GuardarUsuario(usuario);
            Snackbar.Add("Usuario actualizado", Severity.Success, a => a.VisibleStateDuration = 200);
            NavigateToHome();
        }
        else
        {
            confirmarGuardar = true;

            List<Usuario> usuarios = (List<Usuario>)await ServicioUsuario.ObtenerUsuarios();

            foreach (var item in usuarios)
            {
                if (usuario.Nombre.ToUpper().Equals(item.Nombre))
                {
                    usuarioReplicado = true;
                }
            }
            if (usuarioReplicado)
            {
                var confirmacion = await js.InvokeAsync<bool>("confirmar", "Usuario existente", "¿Guardar de todas formas?", "question");

                if (confirmacion)
                {
                    await ServicioUsuario.GuardarUsuario(usuario);
                    Snackbar.Add("Usuario agregado", Severity.Success, a => a.VisibleStateDuration = 200);
                }
                else
                {
                    confirmarGuardar = false;
                }
            }
            else
            {
                await ServicioUsuario.GuardarUsuario(usuario);
                Snackbar.Add("Usuario agregado", Severity.Success, a => a.VisibleStateDuration = 200);
            }

        }

        if (confirmarGuardar)
            NavigateToHome();
    }

    protected async Task Cancelar()
    {
        await Task.Yield();
        NavigateToHome();
    }

    private void NavigateToHome()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario ServicioUsuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioSucursal ServicioSucursal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioAgencia ServicioAgencia { get; set; }
    }
}
#pragma warning restore 1591
