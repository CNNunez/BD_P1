#pragma checksum "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ac3b1f65c9217132795704d1bf1dee0cc08ed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\_ViewImports.cshtml"
using BD_P1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\_ViewImports.cshtml"
using BD_P1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ac3b1f65c9217132795704d1bf1dee0cc08ed7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe23d2a2dc7198deef462ff1caa7ed05d8db6aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ac3b1f65c9217132795704d1bf1dee0cc08ed73238", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 6 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Carolina Narvaez</title>\r\n    ");
#nullable restore
#line 7 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
Write(Styles.Render("~/Content/css"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/modernizr"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ac3b1f65c9217132795704d1bf1dee0cc08ed75079", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("    <div class=\"jumbotron jumbotron-fixed-top jumbotron-fluid text-center bg-dark text-white\" style=\"margin-bottom:0\">\r\n        <h1 class=\"display-1 text-warning\">Challenge</h1>\r\n        <p class=\"display-4\">ForsyteIT Solutions</p>\r\n    </div>\r\n\r\n\r\n");
                WriteLiteral("    <div class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\r\n        <div class=\"container\">\r\n            <div class=\"navbar-header\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Home", "Index", new { area = "" }, new { @class = "navbar-brand" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Challenge", "Challenge", new { area = "" }, new { @class = "navbar-brand" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
                WriteLiteral("    <div class=\"container body-content\">\r\n        ");
#nullable restore
#line 32 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <hr />\r\n        <footer class=\"navbar navbar-fixed-bottom\">\r\n            <p>&copy; ");
#nullable restore
#line 35 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - FSIT Challenge</p>\r\n        </footer>\r\n    </div>\r\n\r\n\r\n    ");
#nullable restore
#line 40 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 41 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/bootstrap"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 42 "C:\Users\Carolina\Documents\TEC\2021\BD\BD_P1\BD_P1\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
