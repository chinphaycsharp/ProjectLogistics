#pragma checksum "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "825b53e7343a3f7e435a865332265398a10ffa4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Index), @"mvc.1.0.view", @"/Views/Comment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"825b53e7343a3f7e435a865332265398a10ffa4a", @"/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce9d90277bfa341e206d4dc8d3579259bed612a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Logistics.Service.Commons.PaginatedList<Logistics.Data.Entities.Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/notification.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "825b53e7343a3f7e435a865332265398a10ffa4a4633", async() => {
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
                WriteLiteral(@"
    <script>
        Init();

        function Init() {
            InitDatetimePicker();
            GetOrderUsingAjax(1);
        }

        function InitDatetimePicker() {
            $(""#datepicker_start"").datepicker();
            $(""#datepicker_end"").datepicker();
        }

        function GetOrderUsingAjax(pageNum, pageSize) {
            $(""#paged"").empty();
            var OrderSearch = new Object();
            var searchValue = document.getElementById('search_value');

            OrderSearch.SearchValue = null;
            OrderSearch.PageIndex = pageNum;
            OrderSearch.PageNumber = 2;


            if (searchValue.value != null && searchValue.value != """") {
                OrderSearch.SearchValue = searchValue.value;
            }
            $.ajax({
                type: 'GET',
                url: 'https://localhost:44358/Comment/GetComments',
                dataType: 'json',
                data: { body: JSON.stringify(OrderSearch) },
             ");
                WriteLiteral(@"   success: function (data) {
                    console.log(data.resultObj);
                    $('#tblcomments tbody > tr').remove();
                    if (data.resultObj.items != null) {
                        var rows;
                        $.each(data.resultObj.items, function (i, item) {
                            rows += ""<tr>""
                                + ""<td>"" + item.clientName + ""</td>""
                                + ""<td>"" + item.countStars + ""</td>""
                                + ""<td>"" + item.createdDate + ""</td>""
                                + ""<td> <a class='btn btn-warning' href='/Comment/Detail/"" + item.id + ""'><i class='ti ti-edit'></i></a><button type ='button' class='btn btn-danger' onclick='DeleteRecord("" + item.id + "")' ><i class='ti ti-trash-x'></i></button></td>""
                                + ""</tr>"";
                            ;
                        });
                        $('#tblcomments tbody').append(rows);
                        P");
                WriteLiteral(@"aggingTemplate(data.resultObj.totalPages, data.resultObj.pageIndex);
                    }
                },
                error: function (emp) {
                    alert('error');
                }
            });
        }

        function PaggingTemplate(totalPage, currentPage) {
            console.log(totalPage);
            console.log(currentPage);
            var template = """";
            var TotalPages = totalPage;
            var CurrentPage = currentPage;
            var PageNumberArray = Array();


            var countIncr = 1;
            for (var i = currentPage; i <= totalPage; i++) {
                PageNumberArray[0] = currentPage;
                if (totalPage != currentPage && PageNumberArray[countIncr - 1] != totalPage) {
                    PageNumberArray[countIncr] = i + 1;
                }
                countIncr++;
            };
            PageNumberArray = PageNumberArray.slice(0, 5);
            var FirstPage = 1;
            var LastPage = t");
                WriteLiteral(@"otalPage;
            if (totalPage != currentPage) {
                var ForwardOne = currentPage + 1;
            }
            var BackwardOne = 1;
            if (currentPage > 1) {
                BackwardOne = currentPage - 1;
            }

            template = ""<p>"" + CurrentPage + "" of "" + TotalPages + "" pages</p>""
            template = template + '<ul class=""pagination"">' +
                '<li class=""previous""><a href=""#"" onclick=""GetOrderUsingAjax(' + FirstPage + ')""><i class=""ti ti-arrow-big-left-filled""></i>&nbsp;First</a></li>' +
                '<li><a href=""#"" onclick=""GetOrderUsingAjax(' + BackwardOne + ')""><<</a>';

            var numberingLoop = """";
            for (var i = 0; i < PageNumberArray.length; i++) {
                numberingLoop = numberingLoop + '<a class=""page-number active"" onclick=""GetOrderUsingAjax(' + PageNumberArray[i] + ')"" href=""#"">' + PageNumberArray[i] + ' &nbsp;&nbsp;</a>'
            }
            template = template + numberingLoop + '<a href");
                WriteLiteral(@"=""#"" onclick=""GetOrderUsingAjax(' + ForwardOne + ')"" >>></a></li>' +
                '<li class=""next""><a href=""#"" onclick=""GetOrderUsingAjax(' + LastPage + ')"">Last&nbsp;<i class=""ti ti-arrow-big-right-filled""></i></a></li></ul>';
            $(""#paged"").append(template);

        }

        function UpdateStatus(id) {
            console.log(id);
            $.ajax({
                type: 'POST',
                url: 'https://localhost:44358/Order/UpdateStatus',
                dataType: 'json',
                data: { id: id },
                success: function (data) {
                    console.log(data);
                    if (data.resultObj == true) {
                        CreateNotification(data.message, ""success"");
                        GetOrderUsingAjax(1);
                    }
                    else {
                        CreateNotification(data.message, ""error"");
                    }
                },
                error: function (emp) {
                   ");
                WriteLiteral(@" alert('error');
                }
            })
        }

        function DeleteRecord(id){
            $.ajax({
                type: 'POST',
                url: 'https://localhost:44358/Comment/DeleteComment',
                dataType: 'json',
                data: { id: id },
                success: function (data) {
                    console.log(data);
                    if (data.resultObj == true) {
                        CreateNotification(data.message, ""success"");
                        GetOrderUsingAjax(1);
                    }
                    else {
                        CreateNotification(data.message, ""error"");
                    }
                },
                error: function (emp) {
                    alert('error');
                }
            })
        }
    </script>
");
            }
            );
            WriteLiteral(@"
<style>
    #container {
        position: fixed;
        bottom: 10px;
        right: 10px;
    }
</style>
<div id=""container""></div>
<div class=""page-wrapper"" id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin6"" data-sidebartype=""full""
     data-sidebar-position=""fixed"" data-header-position=""fixed"">
    <!--  Main wrapper -->
    <div class=""body-wrapper"">
        <!--  Header Start -->
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "825b53e7343a3f7e435a865332265398a10ffa4a12458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <!--  Header End -->\r\n        <div>\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title fw-semibold mb-4\">List orders</h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "825b53e7343a3f7e435a865332265398a10ffa4a13807", async() => {
                WriteLiteral(@"
                        <div class=""form-actions no-color"">
                            <p>
                                <div class=""row"">
                                    <div class=""col-lg-4 d-flex align-items-strech"">
                                        <input type=""text"" id=""search_value"" class=""form-control"" placeholder=""Search for name and order id"" />
                                    </div>
                                    <div class=""col-lg-3 d-flex align-items-strech"">
                                        <input id=""datepicker_start"" type=""text"" placeholder=""Start Date"" class=""form-control"" />
                                    </div>
                                    <div class=""col-lg-3 d-flex align-items-strech"">
                                        <input id=""datepicker_end"" type=""text"" placeholder=""End Date"" class=""form-control"" />
                                    </div>
                                    <div class=""col-lg-2"">
                        ");
                WriteLiteral(@"                <input type=""button"" value=""Search"" class=""btn btn-primary"" onclick=""GetOrderUsingAjax()"" />
                                    </div>
                                </div>
                            </p>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""col-lg-12 d-flex align-items-stretch"">
                        <div class=""card w-100"">
                            <div class=""card-body p-4"">
                                <div class=""table-responsive"">
                                    <table class=""table text-nowrap mb-0 align-middle"" id=""tblcomments"">
                                        <thead class=""text-dark fs-4"">
                                            <tr>
                                                <th class=""border-bottom-0"">
                                                    <h6 class=""fw-semibold mb-0"">Client Name</h6>
                                                </th>
                                                <th class=""border-bottom-0"">
                                                    <h6 class=""fw-semibold mb-0"">Count Star</h6>
                                                </th>
                                                <th class=""border-bottom-0"">
          ");
            WriteLiteral(@"                                          <h6 class=""fw-semibold mb-0"">Comment Date</h6>
                                                </th>
                                                <th class=""border-bottom-0 text-center"">
                                                    <h6 class=""fw-semibold mb-0"">###</h6>
                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                        </tbody>
                                    </table>
                                </div>
                                <div style=""margin-top:10px"">
                                    <nav aria-label=""Page navigation example"" id=""paged"">
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>");
            WriteLiteral("\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Logistics.Service.Commons.PaginatedList<Logistics.Data.Entities.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
