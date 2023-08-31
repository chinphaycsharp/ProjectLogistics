#pragma checksum "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\OrderClient\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec9a3296cece7c9d10b415320927744abcb3880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ClientApp_Views_OrderClient_Add), @"mvc.1.0.view", @"/Areas/ClientApp/Views/OrderClient/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec9a3296cece7c9d10b415320927744abcb3880", @"/Areas/ClientApp/Views/OrderClient/Add.cshtml")]
    #nullable restore
    public class Areas_ClientApp_Views_OrderClient_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/notification.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\OrderClient\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_LayoutClient.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    #container {\r\n        position: fixed;\r\n        bottom: 10px;\r\n        right: 10px;\r\n    }\r\n</style>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec9a3296cece7c9d10b415320927744abcb38803571", async() => {
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
        var products = [];
        var productItems = [];
        var productids = [];
        Init();

        function Init() {
            console.log(1);
            LoadProducts(0);
            InitDatetimePicker();
        }

        function InitDatetimePicker() {
            $(""#delivery_date"").datepicker();
            $(""#estimate_delivery_date"").datepicker();
        }

        function LoadProducts(value) {
            $.ajax({
                type: ""GET"",
                url: ""https://localhost:44358/ClientApp/ProductClient/GetProducts"",
                success: function (data) {
                    var s = '<option value="""">Please Select a Product</option>';
                    console.log(data.resultObj);
                    products = data.resultObj;
                    for (var i = 0; i < data.resultObj.length; i++) {
                        s += '<option value=""' + data.resultObj[i].id + '"">' + data.resultObj[i].name + '</option>';
                  ");
                WriteLiteral(@"  }
                    $(`#productsDropdown-${value}`).html(s);
                }
            });

        }

        function AddRow() {
            var lastDropDown = document.querySelectorAll('select');
            var split_id = lastDropDown[lastDropDown.length - 1].id.split('-');
            var lastIndex = split_id[split_id.length - 1];

            var txtProductId = document.getElementById(`productid-${(lastIndex.toString())}`);
            var txtQuantity = document.getElementById(`quantity-${(lastIndex.toString())}`);
            var checked = true;
            if (txtProductId.value === """" || txtProductId.value === null)
            {
                CreateNotification(""Please choose product"",""error"");
                checked = false;
                return;
            }

            if (txtQuantity.value === """" || txtQuantity.value === null) {
                CreateNotification(""Please fill quantity"", ""error"");
                checked = false;
                return;
  ");
                WriteLiteral(@"          }

            if(checked)
            {
                lastIndex = parseInt(lastIndex) + 1;
                LoadProducts(lastIndex);
                var rows = """";
                rows += ""<tr id='product-"" + lastIndex.toString() + ""'>""
                    + ""<td class='border-bottom-0'><select class='form-select' id='productsDropdown-"" + lastIndex.toString() + ""' onchange='OnSelectProduct(this)'><option value=''>Please Select a Product</option></select></td > ""
                    + ""<td><input type='text' class='form-control' id='productid-"" + lastIndex.toString() + ""'></td>""
                    + ""<td><input type='text' class='form-control' id='price-"" + lastIndex.toString() + ""'></td>""
                    + ""<td><input type='text' class='form-control' id='quantity-"" + lastIndex.toString() + ""' onkeyup='ChangeQuanity(this)'></td>""
                    + ""<td><input type='text' class='form-control' id='totalprice-"" + lastIndex.toString() + ""'></td>""
                    + ""<td><button");
                WriteLiteral(@" class='btn btn-secondary' type='button' onclick='AddRow()' ><i class='ti ti-plus'></i></button></td>""
                    + ""</tr>"";
                ;
                $('#tblorders tbody').append(rows);
            }
        }

        function OnSelectProduct(value)
        {
            var lastDropDown = document.querySelectorAll('select');
            var Last_Split_id = lastDropDown[lastDropDown.length - 1].id.split('-');
            var Last_Value = lastDropDown[lastDropDown.length - 1].value;
            var lastIndexOption = Last_Split_id[Last_Split_id.length - 1];
            if(lastIndexOption !== ""0"")
            {
                lastIndexOption = parseInt(lastIndexOption) - 1;
            }
            var a = `productid-${(lastIndexOption.toString())}`;
            var b = `price-${(lastIndexOption.toString())}`;
            var txtProductId = document.getElementById(a);
            var txtPrice = document.getElementById(b);

            var p = products.find((e) => e.id =");
                WriteLiteral(@"= Last_Value);
            var isExist = productids.find((e)=>e == Last_Value);

            if(isExist)
            {
                CreateNotification(""You have selected this product, please add quantity"", ""error"");
                LoadProducts(lastIndexOption + 1);
            }
            else{
                var split_id = value.id.split('-');
                var lastIndex = split_id[split_id.length - 1];
                lastIndex = parseInt(lastIndex);
                txtProductId = document.getElementById(`productid-${(lastIndex.toString())}`);
                txtPrice = document.getElementById(`price-${(lastIndex.toString())}`);
                txtProductId.value = Last_Value;
                txtPrice.value = p.price;
                productids.push(Last_Value);
            }
        }

        function ChangeQuanity(event)
        {
            var split_id = event.id.split('-');
            var lastIndex = split_id[split_id.length - 1];
            var quantity = `quantity");
                WriteLiteral(@"-${(lastIndex.toString())}`;
            var price = `price-${(lastIndex.toString())}`;
            var totalprice = `totalprice-${(lastIndex.toString())}`;
            var txtquantity = document.getElementById(quantity);
            var txtprice = document.getElementById(price);
            var txtTotalPrice = document.getElementById(totalprice);
            txtTotalPrice.value = parseInt(txtprice.value) * parseInt(txtquantity.value);
        }

        function AddOrder() {
            var selects = document.querySelectorAll('select');
            var orderId = document.getElementById('identity');
            var name = document.getElementById('name');
            var email = document.getElementById('email');
            var address = document.getElementById('address');
            var phone = document.getElementById('phone');
            var delivery_date = document.getElementById('delivery_date');
            var status = document.getElementById('status');
            var delivery_addres");
                WriteLiteral(@"s = document.getElementById('delivery_address');
            for(var i = 0; i < selects.length; i++)
            {
                var split_id = selects[i].id.split('-');
                var last_value = split_id[split_id.length - 1];
                var productId = `productid-${(last_value.toString())}`;
                var quantity = `quantity-${(last_value.toString())}`;
                var totalprice = `totalprice-${(last_value.toString())}`;
                var txtquantity = document.getElementById(quantity);
                var txtproductId = document.getElementById(productId);
                var txtTotalPrice = document.getElementById(totalprice);
                var item = new Object();
                item.OrderId = orderId.value;
                item.ProductId = txtproductId.value;
                item.TotalPrice = txtTotalPrice.value;
                item.Quantity = txtquantity.value;
                productItems.push(item);
            }
            var order = new Object();
 ");
                WriteLiteral(@"           order.OrderId = orderId.value;
            order.CustomerName = name.value;
            order.CustomerAddress = address.value;
            order.CustomerPhone = phone.value;
            order.CustomerEmail = email.value;
            order.DeliveryDate = delivery_date.value;
            order.status = status.checked;
            order.delivery_address = delivery_address.value;
            order.OrderItems = productItems;
            console.log(order);
            $.ajax({
                type: 'POST',
                url: 'https://localhost:44358/ClientApp/OrderClient/Add',
                dataType: 'json',
                data: { body: JSON.stringify(order) },
                success: function (data) {
                    console.log(data);
                    if (data.resultObj == true) {
                        CreateNotification(data.message, ""success"");
                        window.location.href = ""https://localhost:44358/ClientApp/OrderClient/Index"";
                    ");
                WriteLiteral(@"}
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
<div class=""page-wrapper"" id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin6"" data-sidebartype=""full""
     data-sidebar-position=""fixed"" data-header-position=""fixed"">

    <!--  Main wrapper -->
    <div class=""body-wrapper"">
        <!--  Header Start -->
        <partial name=""_Header"" />
        <!--  Header End -->
        <div class=""container-fluid"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title fw-semibold mb-4"">Add order</h5>
                    <div class=""card"">
                        <div class=""card-body"">
                            <form>
                                <div class=""mb-3"">
                                    <label class=""form-label"">Order Id</label>
                                    <input type=""text"" class=""form-control"" id=""identity"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""for");
            WriteLiteral(@"m-label"">Customer Email</label>
                                    <input type=""text"" class=""form-control"" id=""email"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"">Customer Name</label>
                                    <input type=""text"" class=""form-control"" id=""name"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"">Customer Address</label>
                                    <input type=""text"" class=""form-control"" id=""address"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"">Customer Phone</label>
                                    <input type=""text"" class=""form-control"" id=""phone"">
                                </div>
                                <div class=""mb-3"">
       ");
            WriteLiteral(@"                             <label class=""form-label"">Delivery Date</label>
                                    <input id=""delivery_date"" type=""text"" class=""form-control"" />
                                </div>
                                <div class=""mb-3"">
                                    <input type=""checkbox"" class=""form-check-input"" id=""status"">
                                    <label class=""form-check-label""  >Status Delivered</label>
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"">Delivery Address</label>
                                    <input type=""text"" class=""form-control"" id=""delivery_address"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"">Products</label>
                                    <div class=""table-responsive"">
                                        <");
            WriteLiteral(@"table class=""table text-nowrap mb-0 align-middle"" id=""tblorders"">
                                            <thead class=""text-dark fs-4"">
                                                <tr>
                                                    <th class=""border-bottom-0"">
                                                        <h6 class=""fw-semibold mb-0"">Name</h6>
                                                    </th>
                                                    <th class=""border-bottom-0"">
                                                        <h6 class=""fw-semibold mb-0"">ProductId</h6>
                                                    </th>
                                                    <th class=""border-bottom-0"">
                                                        <h6 class=""fw-semibold mb-0"">Price</h6>
                                                    </th>
                                                    <th class=""border-bottom-0"">
                            ");
            WriteLiteral(@"                            <h6 class=""fw-semibold mb-0"">Quantity</h6>
                                                    </th>
                                                    <th class=""border-bottom-0"">
                                                        <h6 class=""fw-semibold mb-0"">TotalPrice</h6>
                                                    </th>
                                                    <th class=""border-bottom-0"">
                                                        <h6 class=""fw-semibold mb-0"">###</h6>
                                                    </th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr id=""product-0"">
                                                    <td class=""border-bottom-0"">
                                                        <select class=""form-select"" id=""productsDropd");
            WriteLiteral(@"own-0"" onchange=""OnSelectProduct(this)"">
                                                        </select>
                                                    </td>
                                                    <td class=""border-bottom-0"">
                                                        <input type=""text"" class=""form-control"" id=""productid-0"">
                                                    </td>
                                                    <td class=""border-bottom-0"">
                                                        <input type=""text"" class=""form-control"" id=""price-0"">
                                                    </td>
                                                    <td class=""border-bottom-0"">
                                                        <input type=""text"" class=""form-control"" id=""quantity-0"" onkeyup=""ChangeQuanity(this)"">
                                                    </td>
                                                    <td class=""");
            WriteLiteral(@"border-bottom-0"">
                                                        <input type=""text"" class=""form-control"" id=""totalprice-0"">
                                                    </td>
                                                    <td class=""border-bottom-0"">
                                                        <button class=""btn btn-secondary"" type=""button"" onclick=""AddRow()""><i class=""ti ti-plus""></i></button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                ");
#nullable restore
#line 296 "C:\Users\PC\source\repos\Logistics\Logistics.WebAppAdmin\Areas\ClientApp\Views\OrderClient\Add.cshtml"
                           Write(Html.ActionLink("Back", "Index", "OrderClient", new { area = "ClientApp" }, new { @class = "btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <button class=\"btn btn-success\" type=\"button\" onclick=\"AddOrder()\"");
            BeginWriteAttribute("value", " value=\"", 15888, "\"", 15896, 0);
            EndWriteAttribute();
            WriteLiteral(">Add</button>\r\n                            </form>\r\n                        </div>\r\n                        <div id=\"container\"></div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
