#pragma checksum "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e07473b8e3a21eda07b3bf63d9cef5990208988"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NavMenu), @"mvc.1.0.view", @"/Views/Shared/NavMenu.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\_ViewImports.cshtml"
using CPTracker1p1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\_ViewImports.cshtml"
using CPTracker1p1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e07473b8e3a21eda07b3bf63d9cef5990208988", @"/Views/Shared/NavMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c24b333bb9a0d783fd093398f938468da9a4b7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_NavMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e07473b8e3a21eda07b3bf63d9cef59902089883855", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"d-flex\" id=\"wrapper\">\r\n        <div class=\"bg-light border-light\" id=\"sidebar-wrapper\">\r\n            <div class=\"sidebar-heading\">Main Menu</div>\r\n            <div class=\"list-group list-group-flush\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 433, "\"", 468, 1);
#nullable restore
#line 15 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
WriteAttributeValue("", 440, Url.Action("Index", "Home"), 440, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action bg-light\"\r\n                   onclick=\"myFunc()\">Dashboard</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 598, "\"", 641, 1);
#nullable restore
#line 17 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
WriteAttributeValue("", 605, Url.Action("Index", "AddressBooks"), 605, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action bg-light\"\r\n                   onclick=\"myFunc\">Contacts</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 768, "\"", 808, 1);
#nullable restore
#line 19 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
WriteAttributeValue("", 775, Url.Action("SentItem", "Parcel"), 775, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action bg-light\"\r\n                   onclick=\"myFunc()\">Sent Items</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 939, "\"", 982, 1);
#nullable restore
#line 21 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
WriteAttributeValue("", 946, Url.Action("ReceiveItem", "Parcel"), 946, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action bg-light\">Recieved Items</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1078, "\"", 1119, 1);
#nullable restore
#line 22 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
WriteAttributeValue("", 1085, Url.Action("AddBranch", "Branch"), 1085, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action bg-light\">Add Branch</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1211, "\"", 1256, 1);
#nullable restore
#line 23 "C:\Users\Lenovo\Documents\GitHub\CPTracker1p1\CPTracker1p1\Views\Shared\NavMenu.cshtml"
WriteAttributeValue("", 1218, Url.Action("ViewAllBranch", "Branch"), 1218, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""list-group-item list-group-item-action bg-light"">All Branch</a>
                <a href=""#"" class=""list-group-item list-group-item-action bg-light"">Add Employee</a>
                <a href=""#"" class=""list-group-item list-group-item-action bg-light"">All Employees</a>

            </div>

        </div>

        <div id=""page-content-wrapper"">
");
                WriteLiteral("\r\n");
                WriteLiteral(@"
        </div>

    </div>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""vendor/jquery/jquery.min.js""></script>

    <script>
        $(""#menu-toggle"").click(function (e) {
            e.preventDefault();
            $(""#wrapper"").toggleClass(""toggled"");

        });
    </script>

    <script>
        function myFunc() {
            var x = document.getElementById(""myDiv"");
            if (x.style.display === ""none"") {
                x.style.display = ""block"";
            }
            else {
                x.style.display = ""none"";
            }
        }
    </script>

    <div class=""container body-content"">
        <asp:ContentPlaceHolder ID=""MainContent"" runat=""server"">
        </asp:ContentPlaceHolder>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
