#pragma checksum "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "419658c2f107a3206e7388d79f5b4682309bc9e3b5c7bbd5ebcc0aabd8290ef5"
// <auto-generated/>
#pragma warning disable 1591
namespace MediocreWeatherService.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using MediocreWeatherService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\_Imports.razor"
using MediocreWeatherService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
using MediocreWeatherService.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
using MediocreWeatherService.Services.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class LocationSearch : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 5 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
                  locationSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "p");
                __builder2.AddAttribute(9, "b-5kk0pxvb1i");
                __builder2.OpenElement(10, "label");
                __builder2.AddAttribute(11, "b-5kk0pxvb1i");
                __builder2.AddMarkupContent(12, "\r\n            Enter a place:\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
                                    locationSearch.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => locationSearch.Location = __value, locationSearch.Location))));
                __builder2.AddAttribute(17, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => locationSearch.Location));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.AddMarkupContent(19, "<p b-5kk0pxvb1i><button type=\"submit\" class=\"btn btn-primary\" b-5kk0pxvb1i>Submit</button></p>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
 if (locations != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MediocreWeatherService.Components.LocationSelect>(20);
            __builder.AddAttribute(21, "Locations", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<MediocreWeatherService.DTO.Location>>(
#nullable restore
#line 21 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
                               locations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnSelectLocation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::MediocreWeatherService.DTO.Location>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::MediocreWeatherService.DTO.Location>(this, 
#nullable restore
#line 22 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
                                  HandleOnSelectLocation

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 23 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Components\LocationSearch.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
