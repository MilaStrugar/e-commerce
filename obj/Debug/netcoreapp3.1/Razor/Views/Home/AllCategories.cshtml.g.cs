#pragma checksum "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "764b454572942607ce3141da441629ee03e4eb25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCategories), @"mvc.1.0.view", @"/Views/Home/AllCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764b454572942607ce3141da441629ee03e4eb25", @"/Views/Home/AllCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a634b606c749c62bc1240e282714d850e6c44d5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Below is the list of all the product categories our vendors are offering<h4>\n<table class=\"table table-hover\">\n");
#nullable restore
#line 4 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
 foreach (var c in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <thead>\n        <tr>\n            <th>");
#nullable restore
#line 8 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
           Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        </tr>\n    </thead>\n");
#nullable restore
#line 11 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
     foreach (var p in c.ProductCategories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody>\n        <tr>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 339, "\"", 375, 2);
            WriteAttributeValue("", 346, "/product/", 346, 9, true);
#nullable restore
#line 15 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
WriteAttributeValue("", 355, p.Product.ProductId, 355, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\">");
#nullable restore
#line 15 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
                                                                           Write(p.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n        </tr>\n    </tbody>\n");
#nullable restore
#line 18 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/catieherrin/Desktop/dojo_assignments/CSharp/FarmersMarket/Views/Home/AllCategories.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
