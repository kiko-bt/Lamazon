#pragma checksum "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c05336fafae5d764ec305b3bd657b0724c6ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ListAllOrders), @"mvc.1.0.view", @"/Views/Order/ListAllOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c05336fafae5d764ec305b3bd657b0724c6ae2", @"/Views/Order/ListAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1311924cc4ce16d957f9519afa0abdb9ecc31b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ListAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "approveOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "declineOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
  
    ViewData["Title"] = "ListAllOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>All Users orders</h1>


<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">User full name</th>
                <th scope=""col"">Products</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
             foreach (var order in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                   Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                   Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                   Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                   Write(order.User.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                       
                        int i = 0;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n");
#nullable restore
#line 33 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                     foreach (var product in order.Products)
                    {
                        i++;
                        if (order.Products.Count() == i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 38 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                             Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 42 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                             Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</span>\r\n");
#nullable restore
#line 43 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n");
#nullable restore
#line 46 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                     if (order.Status == StatusTypeViewModel.Pending)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c05336fafae5d764ec305b3bd657b0724c6ae29256", async() => {
                WriteLiteral("Approve");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                                                                                       WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c05336fafae5d764ec305b3bd657b0724c6ae211810", async() => {
                WriteLiteral("Decline");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                                                                                       WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 52 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                    }
                    else if (order.Status == StatusTypeViewModel.Confirmed)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Waiting to be delivered</td>\r\n");
#nullable restore
#line 56 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                    }
                    else if(order.Status == StatusTypeViewModel.Declined)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>You have sucessfully declined this order!</td>\r\n");
#nullable restore
#line 60 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Waiting for customer!</td>\r\n");
#nullable restore
#line 64 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Hristijan\Desktop\Lamazon\SEDC.Lamazon\SEDC.Lamazon.WEB\Views\Order\ListAllOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591