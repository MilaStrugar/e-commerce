#pragma checksum "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3d8d93364e9987a885e3da57b8fd557c3e2170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_checkout), @"mvc.1.0.view", @"/Views/Home/checkout.cshtml")]
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
#line 1 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/_ViewImports.cshtml"
using FarmersMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/_ViewImports.cshtml"
using FarmersMarket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3d8d93364e9987a885e3da57b8fd557c3e2170", @"/Views/Home/checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a634b606c749c62bc1240e282714d850e6c44d5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/checkout.cshtml"
Write(ViewBag.loggedUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" owes $");
#nullable restore
#line 1 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/checkout.cshtml"
                                   Write(ViewBag.Total.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
