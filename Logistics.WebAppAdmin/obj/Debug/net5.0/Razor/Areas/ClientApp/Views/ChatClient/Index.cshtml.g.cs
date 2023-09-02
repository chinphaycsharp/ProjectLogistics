#pragma checksum "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\ChatClient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a84817c2f88d900edeb21627e3755b5af67278b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ClientApp_Views_ChatClient_Index), @"mvc.1.0.view", @"/Areas/ClientApp/Views/ChatClient/Index.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\ChatClient\Index.cshtml"
using Logistics.WebAppAdmin.Commons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\ChatClient\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\ChatClient\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\ChatClient\Index.cshtml"
using QuanLySinhVien.WebApp.Commons;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a84817c2f88d900edeb21627e3755b5af67278b", @"/Areas/ClientApp/Views/ChatClient/Index.cshtml")]
    #nullable restore
    public class Areas_ClientApp_Views_ChatClient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/notification.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\ChatClient\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutClient.cshtml";

    var sess = HttpContextAccessor.HttpContext.Session.GetString(CommonConst.user_session);
    UserStorage model = null;
    var isAdmin = false;
    if (sess != null)
    {
        model = JsonConvert.DeserializeObject<UserStorage>(sess);
        isAdmin = true;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    * {
        font-family: 'Avenir';
    }

    .bubbleWrapper {
        padding: 10px 10px;
        display: flex;
        justify-content: flex-end;
        flex-direction: column;
        align-self: flex-end;
        color: #fff;
    }

    .inlineContainer {
        display: inline-flex;
    }

        .inlineContainer.own {
            flex-direction: row-reverse;
        }

    .inlineIcon {
        width: 20px;
        object-fit: contain;
    }

    .ownBubble {
        min-width: 60px;
        max-width: 700px;
        padding: 14px 18px;
        margin: 6px 8px;
        background-color: #5b5377;
        border-radius: 16px 16px 0 16px;
        border: 1px solid #443f56;
    }

    .otherBubble {
        min-width: 60px;
        max-width: 700px;
        padding: 14px 18px;
        margin: 6px 8px;
        background-color: #6C8EA4;
        border-radius: 16px 16px 16px 0;
        border: 1px solid #54788e;
    }

    .own {
        align-");
            WriteLiteral("self: flex-end;\r\n    }\r\n\r\n    .other {\r\n        align-self: flex-start;\r\n    }\r\n\r\n    span.own,\r\n    span.other {\r\n        font-size: 14px;\r\n        color: grey;\r\n    }\r\n</style>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a84817c2f88d900edeb21627e3755b5af67278b6240", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a84817c2f88d900edeb21627e3755b5af67278b7339", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        var connection = new signalR.HubConnectionBuilder().withUrl(""https://localhost:44358/realtime"").build();
        console.log(connection);
        init();

        function init(){
            connection.start()
                .catch(err => console.log(err.toString()));
            LoadMessages();
        }

        function LoadMessages() {
            var searchDto = new Object();
            searchDto.accountId = null;
            searchDto.isAdmin = null;

            $.ajax({
                type: ""GET"",
                url: ""https://localhost:44358/ClientApp/ChatClient/GetMessages"",
                success: function (data) {
                    console.log(data);
                    var template = """";
                    $.each(data.resultObj, function (i, item) {
                        var date_split = item.createdDate.split('T');
                        var time = date_split[date_split.length - 1];
                        var time_split = time.split('");
                WriteLiteral(@":');
                        var time_final = time_split[time_split.length - 3] + "":"" + time_split[time_split.length - 2];
                        console.log(date_split);
                        if (item.isAdmin) {
                            template += ""<div class='bubbleWrapper'>""
                                + ""<div class='inlineContainer own'>""
                                + ""<img class='inlineIcon' src='https://www.pinclipart.com/picdir/middle/205-2059398_blinkk-en-mac-app-store-ninja-icon-transparent.png'>""
                                + ""<div class='ownBubble own'>"" + item.message + ""</div></div>""
                                + ""<span class='own'>"" + time_final + ""</span></div > ""
                        }
                        else {
                            template += ""<div class='bubbleWrapper'><div class='inlineContainer'><img class='inlineIcon' src='https://cdn1.iconfinder.com/data/icons/ninja-things-1/1772/ninja-simple-512.png' >""
                                + ");
                WriteLiteral(@"""<div class='otherBubble other'>"" + item.message + ""</div></div>""
                                + ""<span class='other'>"" + time_final + ""</span></div > ""
                        }
                    });
                    $('#chat-box').append(template);
                }
            });

        }

        function SendMessage(username, isadmin) {
            var message = document.getElementById('txtmes').value;
            console.log(message);
            console.log(username);
            console.log(isadmin);
            var model = new Object();
            model.account_id = username;
            model.message = message;
            model.customer_name = 'Quang Le';
            model.isadmin = isadmin;
            model.alias = username;
            var body = JSON.stringify(model);
            connection.invoke('SendMessage', body);
        }

        connection.on(""ReceiveMessage"", function (account_id, message, customer_name, isAdmin, alias, CreatedDate) {
            ");
                WriteLiteral(@"console.log(account_id);
            console.log(message);
            console.log(customer_name);
            console.log(isAdmin);
            console.log(alias);
            console.log(CreatedDate);
            var template = """";
            var date_split = CreatedDate.split('T');
            var time = date_split[date_split.length - 1];
            var time_split = time.split(':');
            var time_final = time_split[time_split.length - 3] + "":"" + time_split[time_split.length - 2];
            if (isAdmin) {
                template += ""<div class='bubbleWrapper'>""
                    + ""<div class='inlineContainer own'>""
                    + ""<img class='inlineIcon' src='https://www.pinclipart.com/picdir/middle/205-2059398_blinkk-en-mac-app-store-ninja-icon-transparent.png'>""
                    + ""<div class='ownBubble own'>"" + message + ""</div></div>""
                    + ""<span class='own'>"" + time_final + ""</span></div > ""
            }
            else {
                te");
                WriteLiteral(@"mplate += ""<div class='bubbleWrapper'><div class='inlineContainer'><img class='inlineIcon' src='https://cdn1.iconfinder.com/data/icons/ninja-things-1/1772/ninja-simple-512.png' >""
                    + ""<div class='otherBubble other'>"" + message + ""</div></div>""
                    + ""<span class='other'>"" + time_final + ""</span></div > ""
            }
            $('#chat-box').append(template);
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""page-wrapper"" id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin6"" data-sidebartype=""full""
     data-sidebar-position=""fixed"" data-header-position=""fixed"">
    <div class=""body-wrapper"">
        <!--  Header Start -->
        <header class=""app-header"">
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
            WriteLiteral(@"
                </ul>
                <div class=""navbar-collapse justify-content-end px-0"" id=""navbarNav"">
                    <ul class=""navbar-nav flex-row ms-auto align-items-center justify-content-end"">
                        <a href=""https://adminmart.com/product/modernize-free-bootstrap-admin-dashboard/"" target=""_blank"" class=""btn btn-primary"">Download Free</a>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link nav-icon-hover"" href=""javascript:void(0)"" id=""drop2"" data-bs-toggle=""dropdown""
                               aria-expanded=""false"">
                                <img src=""../assets/images/profile/user-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8192, "\"", 8198, 0);
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
          ");
            WriteLiteral(@"                              <i class=""ti ti-list-check fs-6""></i>
                                        <p class=""mb-0 fs-3"">My Task</p>
                                    </a>
                                    <a href=""./authentication-login.html"" class=""btn btn-outline-primary mx-3 mt-2 d-block"">Logout</a>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <!--  Header End -->
        <div class=""container-fluid"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title fw-semibold mb-4"">Chat with staff</h5>
                    <div class=""card"" >
                        <div class=""card-body"" style=""overflow-y:scroll;height:650px"" id=""chat-box"">
                        </div>
                        <div id=""container""></div>
                    </div>
                    <form>
            WriteLiteral(@"
                        <div class=""form-actions no-color"">
                            <p>
                                <div class=""row"">
                                    <div class=""col-lg-11 d-flex align-items-strech"">
                                        <input type=""text"" id=""txtmes"" class=""form-control"" placeholder=""Send message..."" />
                                    </div>
                                    <div class=""col-lg-1"">
                                        <button type=""button"" value=""Search"" class=""btn btn-primary"" onclick=""SendMessage(null,false)""><i class=""ti ti-send""></i></button>
                                    </div>
                                </div>
                            </p>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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