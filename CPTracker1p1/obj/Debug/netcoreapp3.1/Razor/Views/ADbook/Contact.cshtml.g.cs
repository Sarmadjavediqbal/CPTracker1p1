#pragma checksum "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c903520136a9e7c5736e3fc76d684b17edf0f5b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ADbook_Contact), @"mvc.1.0.view", @"/Views/ADbook/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c903520136a9e7c5736e3fc76d684b17edf0f5b1", @"/Views/ADbook/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c24b333bb9a0d783fd093398f938468da9a4b7", @"/Views/_ViewImports.cshtml")]
    public class Views_ADbook_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddressBook>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n");
#nullable restore
#line 14 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\Contact.cshtml"
              
                Html.RenderPartial("NavMenu");
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"container-fluid\">\r\n                <h2>Contacts</h2>\r\n                <div class=\"row\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 542, "\"", 550, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Id</th>
                                    <th scope=""col"">First Name</th>
                                    <th scope=""col"">Last Name</th>
                                    <th scope=""col"">Address</th>
                                    <th scope=""col"">Email Id</th>
                                    <th scope=""col"">Contact No.</th>
                                    <th scope=""col"">Company</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>ID</td>
                                    <td>First Name</td>
                                    <td>Last Name</td>
                                    <td>Address</td>
                                    <td>Email Id</td>
         ");
            WriteLiteral(@"                           <td>Contact No.</td>
                                    <td>Company</td>
                                </tr>
                            </tbody>
                        </table><br /><br /><br /><br /><br /><br /><br /><br /><br />
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination justify-content-end"">
                                <li class=""page-item disabled"">
                                    <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                                </li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">Next</a");
            WriteLiteral(">\r\n                                </li>\r\n                            </ul>\r\n                        </nav>\r\n                    </div>\r\n                    <div class=\"col-md-12\">\r\n                        <button");
            BeginWriteAttribute("href", " href=\"", 2812, "\"", 2960, 1);
#nullable restore
#line 62 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\Contact.cshtml"
WriteAttributeValue("", 2819, Url.Action("CreateContactForm", "CreateContactController", 
                                     new { id = "<CreateContactForm.cshtml>" }), 2819, 141, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark dropright\">\r\n                             ");
#nullable restore
#line 64 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\Contact.cshtml"
                        Write(Html.ActionLink("Create New", "CreateContactForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddressBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
