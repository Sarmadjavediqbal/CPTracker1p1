#pragma checksum "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6940a8ac0e2d5701e4c2cb07d0cb0ba610b1e019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcel_ReceiveItem), @"mvc.1.0.view", @"/Views/Parcel/ReceiveItem.cshtml")]
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
#line 1 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\_ViewImports.cshtml"
using CPTracker1p1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\_ViewImports.cshtml"
using CPTracker1p1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6940a8ac0e2d5701e4c2cb07d0cb0ba610b1e019", @"/Views/Parcel/ReceiveItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c24b333bb9a0d783fd093398f938468da9a4b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Parcel_ReceiveItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parcel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml"
  
    ViewData["Title"] = "ReceiveItem";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n");
#nullable restore
#line 16 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml"
              
                Html.RenderPartial("NavMenu");
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-md-9"">
            <div class=""container-fluid"">
                <h2>Received Items</h2>
                <div class=""row"">
                    <div class=""col-md-10"">
                        <div class=""col-md-5"" style="" padding-top: 20px;"">
                            <button");
            BeginWriteAttribute("href", " href=\"", 686, "\"", 818, 1);
#nullable restore
#line 26 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml"
WriteAttributeValue("", 693, Url.Action("ReceiveNewPar", "ParcelController",
                                     new { id = "<ReceiveNewPar.cshtml>" }), 693, 125, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark dropright\" style=\"width: 180px;\">\r\n                                ");
#nullable restore
#line 28 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml"
                           Write(Html.ActionLink("Courier", "ReceiveNewPar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"col-md-5\" style=\" padding-top: 20px;\">\r\n                            <button");
            BeginWriteAttribute("href", " href=\"", 1143, "\"", 1275, 1);
#nullable restore
#line 32 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml"
WriteAttributeValue("", 1150, Url.Action("ReceiveNewPar", "ParcelController",
                                     new { id = "<ReceiveNewPar.cshtml>" }), 1150, 125, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark dropright\" style=\"width: 180px;\">\r\n                                ");
#nullable restore
#line 34 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\Parcel\ReceiveItem.cshtml"
                           Write(Html.ActionLink("Company Mail", "ReceiveNewPar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parcel> Html { get; private set; }
    }
}
#pragma warning restore 1591
