﻿#pragma checksum "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8630ce1c6f8236d12b437ed78f8b1eba71dc7d41e558cbbf2430b81ec58bf716"
// <auto-generated/>
#pragma warning disable 1591
namespace MediocreWeatherService.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "MediocreWeatherService");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-p85b577jyy");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidebar");
            __builder.AddAttribute(9, "b-p85b577jyy");
            __builder.OpenComponent<global::MediocreWeatherService.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "main");
            __builder.AddAttribute(13, "b-p85b577jyy");
            __builder.AddMarkupContent(14, "<div class=\"top-row px-4\" b-p85b577jyy><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-p85b577jyy>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(15, "article");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddAttribute(17, "b-p85b577jyy");
#nullable restore
#line (16,14)-(16,18) 25 "G:\Software Development\MediocreWeatherService\MediocreWeatherService\Shared\MainLayout.razor"
__builder.AddContent(18, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
