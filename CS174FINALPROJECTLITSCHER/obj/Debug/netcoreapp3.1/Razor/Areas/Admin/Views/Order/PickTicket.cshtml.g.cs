#pragma checksum "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7daef1e44bcf4a7df8c19427e03f0d44502db936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_PickTicket), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/PickTicket.cshtml")]
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
#line 4 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\_ViewImports.cshtml"
using CS174FINALPROJECTLITSCHER.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7daef1e44bcf4a7df8c19427e03f0d44502db936", @"/Areas/Admin/Views/Order/PickTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90915075e89f38f0a97a85cb7e0b114292be39b4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_PickTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
  
	ViewData["Title"] = "PickTicket";
	Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PickTicket</h1>\r\n\r\n<h2>Cust ID: ");
#nullable restore
#line 9 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
        Write(Model.cartCustomer.CartCustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Cust Name: ");
#nullable restore
#line 10 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
          Write(Model.cartCustomer.CartName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"p-lg-5\">\r\n\t<table class=\"table table-bordered table-striped table-sm\">\r\n\t\t<thead>\r\n\t\t\t<tr><th>Product Id</th><th>Quantity</th><th>Name</th></tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 18 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
             foreach(CartItem ci in Model.cartItems)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 21 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
                   Write(ci.CartItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 22 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
                   Write(ci.CartItemQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 23 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
                   Write(ci.CartItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 25 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Areas\Admin\Views\Order\PickTicket.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
