#pragma checksum "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Views\Shared\_SideBarClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb5d87a107501707e82af541a9f2e87a8d8da64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideBarClient), @"mvc.1.0.view", @"/Views/Shared/_SideBarClient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb5d87a107501707e82af541a9f2e87a8d8da64", @"/Views/Shared/_SideBarClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce9d90277bfa341e206d4dc8d3579259bed612a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SideBarClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""left-sidebar"">
    <!-- Sidebar scroll-->
    <div>
        <div class=""brand-logo d-flex align-items-center justify-content-between"">
            <a href=""./index.html"" class=""text-nowrap logo-img"">
                <img src=""../assets/images/logos/dark-logo.svg"" width=""180""");
            BeginWriteAttribute("alt", " alt=\"", 294, "\"", 300, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </a>
            <div class=""close-btn d-xl-none d-block sidebartoggler cursor-pointer"" id=""sidebarCollapse"">
                <i class=""ti ti-x fs-8""></i>
            </div>
        </div>
        <!-- Sidebar navigation-->
        <nav class=""sidebar-nav scroll-sidebar"" data-simplebar="""">
            <ul id=""sidebarnav"">
                <li class=""nav-small-cap"">
                    <i class=""ti ti-dots nav-small-cap-icon fs-4""></i>
                    <span class=""hide-menu"">Home</span>
                </li>
                <li class=""sidebar-item"">
                    <a class=""sidebar-link"" href=""./index.html"" aria-expanded=""false"">
                        <span>
                            <i class=""ti ti-layout-dashboard""></i>
                        </span>
                        <span class=""hide-menu"">Dashboard</span>
                    </a>
                </li>
                <li class=""nav-small-cap"">
                    <i class=""ti ti-dots nav-small-cap-i");
            WriteLiteral(@"con fs-4""></i>
                    <span class=""hide-menu"">System</span>
                </li>
                <li class=""sidebar-item"">
                    <a class=""sidebar-link"" href=""/Order/Index"" aria-expanded=""false"">
                        <span>
                            <i class=""ti ti-article""></i>
                        </span>
                        <span class=""hide-menu"">Orders</span>
                    </a>
                </li>
                <li class=""sidebar-item"">
                    <a class=""sidebar-link"" href=""/Subject/Index"" aria-expanded=""false"">
                        <span>
                            <i class=""ti ti-alert-circle""></i>
                        </span>
                        <span class=""hide-menu"">Messages</span>
                    </a>
                </li>
            </ul>
            <div class=""unlimited-access hide-menu bg-light-primary position-relative mb-7 mt-5 rounded"">
                <div class=""d-flex"">
                   ");
            WriteLiteral(@" <div class=""unlimited-access-title me-3"">
                        <h6 class=""fw-semibold fs-4 mb-6 text-dark w-85"">Logistics System</h6>
                    </div>
                    <div class=""unlimited-access-img"">
                        <img src=""../assets/images/backgrounds/rocket.png""");
            BeginWriteAttribute("alt", " alt=\"", 2647, "\"", 2653, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n        <!-- End Sidebar navigation -->\r\n    </div>\r\n    <!-- End Sidebar scroll-->\r\n</aside>");
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
