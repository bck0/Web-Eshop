#pragma checksum "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197c7133ae91404d108f929f1fe402e6d04d9d65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_CustomerOrders_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/CustomerOrders/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using Faltynek.Eshop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using Faltynek.Eshop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using Faltynek.Eshop.Web.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using Faltynek.Eshop.Web.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197c7133ae91404d108f929f1fe402e6d04d9d65", @"/Areas/Customer/Views/CustomerOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c498c6e21b0d4b484c68a3f72fd54af980fa4d8", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_CustomerOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
  
    ViewData["Title"] = "My Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
  
    if (Model != null && Model != null && Model.Count > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table style=\"width:100%\" class=\"table table-responsive table-striped table-bordered\">\r\n                <tr>\r\n                    <th class=\"col-sm-1\">");
#nullable restore
#line 17 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(nameof(Order.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"col-sm-2\">");
#nullable restore
#line 18 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(nameof(Order.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"col-sm-3\">");
#nullable restore
#line 19 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(nameof(Order.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"col-sm-3\">");
#nullable restore
#line 20 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(nameof(Order.DateTimeCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"col-sm-3\">");
#nullable restore
#line 21 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(nameof(Order.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"col-sm-1\">");
#nullable restore
#line 24 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-sm-2\">");
#nullable restore
#line 25 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(item.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-sm-3\">");
#nullable restore
#line 26 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(item.TotalPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-sm-3\">");
#nullable restore
#line 27 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(item.DateTimeCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-sm-3\">");
#nullable restore
#line 28 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                    Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n\r\n            </table>\r\n");
            WriteLiteral("            <details>\r\n                <summary>Details</summary>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1265, "\"", 1290, 2);
            WriteAttributeValue("", 1270, "order_items_", 1270, 12, true);
#nullable restore
#line 36 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
WriteAttributeValue("", 1282, item.ID, 1282, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h4>Order Items</h4>\r\n                    <table style=\"width:41.667%\" class=\"table table-responsive table-bordered\">\r\n                        <tr>\r\n                            <th class=\"col-sm-3\">");
#nullable restore
#line 40 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                            Write(nameof(Product.ImageAlt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th class=\"col-sm-1\">");
#nullable restore
#line 41 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                            Write(nameof(OrderItem.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th class=\"col-sm-1\">");
#nullable restore
#line 42 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                            Write(nameof(OrderItem.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                          
                            foreach (var itemOrderItems in item.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"col-sm-3\">");
#nullable restore
#line 49 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                                    Write(itemOrderItems.Product.ImageAlt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-sm-1\">");
#nullable restore
#line 50 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                                    Write(itemOrderItems.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-sm-1\">");
#nullable restore
#line 51 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                                                    Write(itemOrderItems.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </details>\r\n            <br />\r\n            <br />\r\n            <br />\r\n");
#nullable restore
#line 61 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Orders are empty!</h2>\r\n");
#nullable restore
#line 66 "C:\Users\User\source\repos\Faltynek.Eshop.Web\Faltynek.Eshop.Web\Areas\Customer\Views\CustomerOrders\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
