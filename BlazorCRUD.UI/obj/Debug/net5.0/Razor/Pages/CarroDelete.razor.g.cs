#pragma checksum "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "560f22676a0a98338fe9e2c661d0f296c034a723"
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
#line 2 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/carrodelete/{id:int}")]
    public partial class CarroDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                  carro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "table");
                __builder2.AddAttribute(4, "class", "table");
                __builder2.OpenElement(5, "tr");
                __builder2.AddMarkupContent(6, "<td>Marca</td>\r\n            ");
                __builder2.OpenElement(7, "td");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.Marca

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.Marca = __value, carro.Marca));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "tr");
                __builder2.AddMarkupContent(14, "<td>Chasis</td>\r\n            ");
                __builder2.OpenElement(15, "td");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.Chasis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.Chasis = __value, carro.Chasis));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "<td>Modelo</td>\r\n            ");
                __builder2.OpenElement(23, "td");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.Modelo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.Modelo = __value, carro.Modelo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "tr");
                __builder2.AddMarkupContent(30, "<td>A??o</td>\r\n            ");
                __builder2.OpenElement(31, "td");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "text");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.ano

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.ano = __value, carro.ano));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "tr");
                __builder2.AddMarkupContent(38, "<td>Foto</td>\r\n            ");
                __builder2.OpenElement(39, "td");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "type", "text");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.foto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.foto = __value, carro.foto));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "tr");
                __builder2.AddMarkupContent(46, "<td>Color</td>\r\n            ");
                __builder2.OpenElement(47, "td");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.color = __value, carro.color));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "tr");
                __builder2.AddMarkupContent(54, "<td>Comentario</td>\r\n            ");
                __builder2.OpenElement(55, "td");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "text");
                __builder2.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                          carro.comentario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => carro.comentario = __value, carro.comentario));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n        ");
                __builder2.OpenElement(61, "tr");
                __builder2.OpenElement(62, "td");
                __builder2.AddAttribute(63, "colspan", "2");
                __builder2.AddAttribute(64, "style", "text-align:center");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "submit");
                __builder2.AddAttribute(67, "value", "Delete");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                                              deleteCarro

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "input");
                __builder2.AddAttribute(71, "type", "button");
                __builder2.AddAttribute(72, "value", "Cancel");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
                                                              cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\xander\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\CarroDelete.razor"
       
    Carro carro = new Carro();

    [Parameter]
    public int id { get; set; }

    protected async Task deleteCarro()
    {
        await CarroServices.deleteCarro(id);
        NavigatioManager.NavigateTo("/carrolist");

    }
    protected override async Task OnInitializedAsync()
    {
        carro = await CarroServices.getDetails(id);
    }

    protected void cancel()
    {
        NavigatioManager.NavigateTo("/carrolist");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigatioManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarroService CarroServices { get; set; }
    }
}
#pragma warning restore 1591
