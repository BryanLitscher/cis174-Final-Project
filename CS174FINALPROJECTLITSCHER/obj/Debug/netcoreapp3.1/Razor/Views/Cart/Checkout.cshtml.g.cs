#pragma checksum "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ecddd06736bf824b0542e20096307b65cf77042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
#line 1 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Views\_ViewImports.cshtml"
using CS174FINALPROJECTLITSCHER.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ecddd06736bf824b0542e20096307b65cf77042", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0a24a78d16a5eac6ff7876edd4ed96084ef705", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"p-4\">\r\n\t<h1>Checkout</h1>\r\n\r\n\t<p>");
#nullable restore
#line 12 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Views\Cart\Checkout.cshtml"
  Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\t<p>Thank you for your order.  ");
#nullable restore
#line 14 "C:\Users\bryan\source\repos\CS174FINALPROJECTLITSCHER\CS174FINALPROJECTLITSCHER\Views\Cart\Checkout.cshtml"
                             Write(Model.TotalValue.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" will be deducted from your next milk check.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
