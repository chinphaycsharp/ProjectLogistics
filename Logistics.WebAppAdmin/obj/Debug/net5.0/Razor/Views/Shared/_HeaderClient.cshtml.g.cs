#pragma checksum "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Views\Shared\_HeaderClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda002a52bda53a09a6829cbf5afc5e0ec1834db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderClient), @"mvc.1.0.view", @"/Views/Shared/_HeaderClient.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Views\_ViewImports.cshtml"
using Logistics.WebAppAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Views\_ViewImports.cshtml"
using Logistics.WebAppAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda002a52bda53a09a6829cbf5afc5e0ec1834db", @"/Views/Shared/_HeaderClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce9d90277bfa341e206d4dc8d3579259bed612a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__HeaderClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header class=""app-header"">
    <nav class=""navbar navbar-expand-lg navbar-light"">
        <ul class=""navbar-nav"">
            <li class=""nav-item d-block d-xl-none"">
                <a class=""nav-link sidebartoggler nav-icon-hover"" id=""headerCollapse"" href=""javascript:void(0)"">
                    <i class=""ti ti-menu-2""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link nav-icon-hover"" href=""javascript:void(0)"">
                    <i class=""ti ti-bell-ringing""></i>
                    <div class=""notification bg-primary rounded-circle""></div>
                </a>
            </li>
        </ul>
        <div class=""navbar-collapse justify-content-end px-0"" id=""navbarNav"">
            <ul class=""navbar-nav flex-row ms-auto align-items-center justify-content-end"">

");
            WriteLiteral(@"                <li class=""nav-item dropdown"">
                    <a class=""nav-link nav-icon-hover"" href=""javascript:void(0)"" id=""drop2"" data-bs-toggle=""dropdown""
                       aria-expanded=""false"">
                        <img src=""../assets/images/profile/user-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1241, "\"", 1247, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""35"" height=""35"" class=""rounded-circle"">
                    </a>
                    <div class=""dropdown-menu dropdown-menu-end dropdown-menu-animate-up"" aria-labelledby=""drop2"">
                        <div class=""message-body"">
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center gap-2 dropdown-item"">
                                <i class=""ti ti-user fs-6""></i>
                                <p class=""mb-0 fs-3"">My Profile</p>
                            </a>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center gap-2 dropdown-item"">
                                <i class=""ti ti-mail fs-6""></i>
                                <p class=""mb-0 fs-3"">My Account</p>
                            </a>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center gap-2 dropdown-item"">
                                <i class=""ti ti-list-check fs-6""></i>
                                <p ");
            WriteLiteral("class=\"mb-0 fs-3\">My Task</p>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
