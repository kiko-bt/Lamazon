#pragma checksum "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f75013f80ec713faa612ff360340cc9f325a6ebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Products), @"mvc.1.0.view", @"/Views/Product/Products.cshtml")]
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
#line 1 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75013f80ec713faa612ff360340cc9f325a6ebf", @"/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1311924cc4ce16d957f9519afa0abdb9ecc31b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n<div class=\"products\">\r\n");
#nullable restore
#line 9 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"img-thumbnail\">\r\n            <img class=\"product-image\"");
            BeginWriteAttribute("src", " src=\"", 241, "\"", 289, 3);
            WriteAttributeValue("", 247, "/images/Products/product-", 247, 25, true);
#nullable restore
#line 12 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
WriteAttributeValue("", 272, product.Id, 272, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 285, ".png", 285, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image\" />\r\n            <div class=\"caption\">\r\n                <h3>");
#nullable restore
#line 14 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h4>");
#nullable restore
#line 15 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
               Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h5>");
#nullable restore
#line 16 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\r\n                <p>\r\n                    <button class=\"btn btn-primary\">Add to card</button>\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Product\Products.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591