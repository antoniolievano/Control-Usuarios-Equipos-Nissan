#pragma checksum "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c28776c597063d77b938484727de0592f4943846"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ListaCorreos : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
 if (correos != null && correos.Any() && usuario != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(4, "Align", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Align>(
#nullable restore
#line 8 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                           Align.Center

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(6, "Correos");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudText>(8);
                __builder2.AddAttribute(9, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 9 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "Align", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Align>(
#nullable restore
#line 9 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                           Align.Center

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 9 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
__builder3.AddContent(12, usuario);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(13, "DialogContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudContainer>(14);
                __builder2.AddAttribute(15, "MaxWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.MaxWidth>(
#nullable restore
#line 12 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                    MaxWidth.Small

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudGrid>(17);
                    __builder3.AddAttribute(18, "Justify", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Justify>(
#nullable restore
#line 13 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                  Justify.Center

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(19, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        global::__Blazor.ControlUsuariosEquipos.Wasm.Client.Pages.Usuarios.ListaCorreos.TypeInference.CreateMudTable_0(__builder4, 20, 21, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                       $"cursor-pointer"

#line default
#line hidden
#nullable disable
                        , 22, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                  correos

#line default
#line hidden
#nullable disable
                        , 23, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                        , 24, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                        , 25, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                        , 26, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                              false

#line default
#line hidden
#nullable disable
                        , 27, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
                        , 28, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                                                              0

#line default
#line hidden
#nullable disable
                        , 29, 
#nullable restore
#line 14 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                                                                             Breakpoint.Md

#line default
#line hidden
#nullable disable
                        , 30, "Sort By", 31, (__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudTh>(32);
                            __builder5.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                global::__Blazor.ControlUsuariosEquipos.Wasm.Client.Pages.Usuarios.ListaCorreos.TypeInference.CreateMudTableSortLabel_1(__builder6, 34, 35, 
#nullable restore
#line 16 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                              new Func<Usuario_Correos, object>(x=>x.NumeroCorreo)

#line default
#line hidden
#nullable disable
                                , 36, (__builder7) => {
                                    __builder7.AddMarkupContent(37, "Número");
                                }
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                            ");
                            __builder5.OpenComponent<global::MudBlazor.MudTh>(39);
                            __builder5.AddAttribute(40, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                global::__Blazor.ControlUsuariosEquipos.Wasm.Client.Pages.Usuarios.ListaCorreos.TypeInference.CreateMudTableSortLabel_2(__builder6, 41, 42, 
#nullable restore
#line 17 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                              new Func<Usuario_Correos, object>(x=>x.Correo)

#line default
#line hidden
#nullable disable
                                , 43, (__builder7) => {
                                    __builder7.AddContent(44, "Correo");
                                }
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(45, "\r\n                            ");
                            __builder5.OpenComponent<global::MudBlazor.MudTh>(46);
                            __builder5.AddAttribute(47, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                global::__Blazor.ControlUsuariosEquipos.Wasm.Client.Pages.Usuarios.ListaCorreos.TypeInference.CreateMudTableSortLabel_3(__builder6, 48, 49, 
#nullable restore
#line 18 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                              new Func<Usuario_Correos, object>(x=>x.Contraseña)

#line default
#line hidden
#nullable disable
                                , 50, (__builder7) => {
                                    __builder7.AddMarkupContent(51, "Contraseña");
                                }
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(52, "\r\n                            ");
                            __builder5.OpenComponent<global::MudBlazor.MudTh>(53);
                            __builder5.CloseComponent();
                        }
                        , 54, (emailContext) => (__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudTd>(55);
                            __builder5.AddAttribute(56, "DataLabel", (object)("NumeroCorreo"));
                            __builder5.AddAttribute(57, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 22 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
__builder6.AddContent(58, emailContext.NumeroCorreo);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n                            ");
                            __builder5.OpenComponent<global::MudBlazor.MudTd>(60);
                            __builder5.AddAttribute(61, "DataLabel", (object)("Correo"));
                            __builder5.AddAttribute(62, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 23 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
__builder6.AddContent(63, emailContext.Correo);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(64, "\r\n                            ");
                            __builder5.OpenComponent<global::MudBlazor.MudTd>(65);
                            __builder5.AddAttribute(66, "DataLabel", (object)("Correo"));
                            __builder5.AddAttribute(67, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 24 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
__builder6.AddContent(68, emailContext.Contraseña);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                            ");
                            __builder5.OpenComponent<global::MudBlazor.MudTd>(70);
                            __builder5.AddAttribute(71, "DataLabel", (object)(""));
                            __builder5.AddAttribute(72, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<global::MudBlazor.MudTooltip>(73);
                                __builder6.AddAttribute(74, "Text", (object)("Copiar correo al portapapeles"));
                                __builder6.AddAttribute(75, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                        Color.Primary

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(76, "Duration", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 26 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                 700

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(77, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<global::MudBlazor.MudFab>(78);
                                    __builder7.AddAttribute(79, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                     (() => CopiarAlPortapapeles(emailContext.Correo))

#line default
#line hidden
#nullable disable
                                    ))));
                                    __builder7.AddAttribute(80, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 27 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                               Color.Default

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.AddAttribute(81, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 27 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                                     Icons.Filled.ContentCopy

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.AddAttribute(82, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 27 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                                                                     Size.Small

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.AddAttribute(83, "IconSize", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 27 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                                                                                                                                                           Size.Small

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n                ");
                    __builder3.OpenComponent<global::MudBlazor.MudGrid>(85);
                    __builder3.AddAttribute(86, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudItem>(87);
                        __builder4.AddAttribute(88, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 33 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                      12

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.OpenComponent<global::MudBlazor.MudItem>(89);
                        __builder4.AddAttribute(90, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 33 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
                                                         12

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(91, "<div class=\"center\"><img src=\"/images/cargando.gif\" width=\"175\" height=\"150\"></div>");
#nullable restore
#line 43 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Víctor Liévano\Documents\Repositorio local\Proyectos Visual Studio\Practicas2022\ControlUsuariosEquipos.Wasm\Client\Pages\Usuarios\ListaCorreos.razor"
       
    public IEnumerable<Usuario_Correos> correos;

    [Parameter]
    public int idUsuarioSeleccionado { get; set; }

    [Parameter]
    public string usuario { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            correos = await ServicioUsuario.ObtenerCorreosPorUsuario(idUsuarioSeleccionado);
        }
        catch (Exception e)
        {

            Console.WriteLine("Error encontrado: " + e.Message);
        }
    }

    private async Task CopiarAlPortapapeles(string texto)
    {
        await ServicioPortapapeles.CopyToClipboard(texto);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioPortapapeles ServicioPortapapeles { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario ServicioUsuario { get; set; }
    }
}
namespace __Blazor.ControlUsuariosEquipos.Wasm.Client.Pages.Usuarios.ListaCorreos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<T> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Int32 __arg7, int __seq8, global::MudBlazor.Breakpoint __arg8, int __seq9, global::System.String __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg11)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Items", (object)__arg1);
        __builder.AddAttribute(__seq2, "Hover", (object)__arg2);
        __builder.AddAttribute(__seq3, "Dense", (object)__arg3);
        __builder.AddAttribute(__seq4, "Striped", (object)__arg4);
        __builder.AddAttribute(__seq5, "Bordered", (object)__arg5);
        __builder.AddAttribute(__seq6, "Square", (object)__arg6);
        __builder.AddAttribute(__seq7, "Elevation", (object)__arg7);
        __builder.AddAttribute(__seq8, "Breakpoint", (object)__arg8);
        __builder.AddAttribute(__seq9, "SortLabel", (object)__arg9);
        __builder.AddAttribute(__seq10, "HeaderContent", (object)__arg10);
        __builder.AddAttribute(__seq11, "RowTemplate", (object)__arg11);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", (object)__arg0);
        __builder.AddAttribute(__seq1, "ChildContent", (object)__arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", (object)__arg0);
        __builder.AddAttribute(__seq1, "ChildContent", (object)__arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", (object)__arg0);
        __builder.AddAttribute(__seq1, "ChildContent", (object)__arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
