#pragma checksum "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de15d3be167db4953e0757adf857f3f4ed7682d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/carrolist")]
    public partial class CarroList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"alert alert-primary\" role=\"alert\"><p>Todos los vehiculos</p></div>");
#nullable restore
#line 9 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
     if (carros == null)
    {



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
                                   }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container principal");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-12 text-center");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
#nullable restore
#line 21 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
                         foreach (var carro in carros)
                        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-lg-4 col-md-12 mb-4");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-section");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card row cardcar ");
            __builder.AddAttribute(16, "style", "width: 18rem;");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "style", "border-radius: 8px;   height: 229px");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 27 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
                                                                                               carro.foto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "class", "card-img-top cardcar");
            __builder.AddAttribute(21, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.OpenElement(25, "h5");
            __builder.AddAttribute(26, "class", "card-title");
#nullable restore
#line 29 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
__builder.AddContent(27, carro.Marca);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                            ");
            __builder.AddMarkupContent(29, "<p class=\"card-text\">En venta</p>\r\n                                            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/carrodetails/" + (
#nullable restore
#line 31 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
                                                                    carro.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i>Editar</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                            ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", "/carrodelete/" + (
#nullable restore
#line 32 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
                                                                   carro.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "<i>Eliminar</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"




                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroList.razor"
           
        private IEnumerable<Carro> carros;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                carros = await CarroServices.getAllCarros();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarroService CarroServices { get; set; }
    }
}
#pragma warning restore 1591
