#pragma checksum "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15718d032e829b8643146a34ca267bd36676de4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ADbook_CreateContactForm), @"mvc.1.0.view", @"/Views/ADbook/CreateContactForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15718d032e829b8643146a34ca267bd36676de4e", @"/Views/ADbook/CreateContactForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c24b333bb9a0d783fd093398f938468da9a4b7", @"/Views/_ViewImports.cshtml")]
    public class Views_ADbook_CreateContactForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddressBook>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
  
    ViewData["Title"] = "CreateContactForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15718d032e829b8643146a34ca267bd36676de4e3632", async() => {
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 22 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
     using (Html.BeginForm(""))
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n");
#nullable restore
#line 26 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
              
                Html.RenderPartial("NavMenu");
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"container-fluid\">\r\n                <h2>New Contact</h2>\r\n                <div class=\"row\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
               Write(Html.TextBoxFor(Model => Model.FirstName, new { @class = "Form-group", @placeholder = "First Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
               Write(Html.TextBoxFor(Model => Model.LastName, new { @class = "Form-group", @placeholder = "Last Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
               Write(Html.TextBoxFor(Model => Model.Address, new { @class = "Form-group", @placeholder = "Address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
               Write(Html.TextBoxFor(Model => Model.EmailId, new { @class = "Form-group", @placeholder = "Email Id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
               Write(Html.TextBoxFor(Model => Model.ContactNo, new { @class = "Form-group", @placeholder = "Contact No." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
               Write(Html.TextBoxFor(Model => Model.Company, new { @class = "Form-group", @placeholder = "Company" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <input runat=\"server\" type=\"submit\" value=\"Save\" id=\"saveContact\" class=\"btn btn-primary\"");
            BeginWriteAttribute("style", " style=\"", 1453, "\"", 1461, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 76 "C:\Users\airblue\source\repos\CPTracker1p1\CPTracker1p1\Views\ADbook\CreateContactForm.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddressBook> Html { get; private set; }
    }
}
#pragma warning restore 1591