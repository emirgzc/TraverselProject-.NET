#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81db16dc1216a7f6a5f964484b87ff8d7f4c1e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AdminLayout), @"mvc.1.0.view", @"/Views/Shared/AdminLayout.cshtml")]
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
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\_ViewImports.cshtml"
using TraverselProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\_ViewImports.cshtml"
using TraverselProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\_ViewImports.cshtml"
using TraverselProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\_ViewImports.cshtml"
using TraverselProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81db16dc1216a7f6a5f964484b87ff8d7f4c1e7", @"/Views/Shared/AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff86cbbc47abc82ece24bbd528f789cebba8973", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
#nullable restore
#line 7 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
Write(await Html.PartialAsync("~/Views/AdminLayoutPartial/HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c81db16dc1216a7f6a5f964484b87ff8d7f4c1e74349", async() => {
                WriteLiteral(@"
    <div id=""preloader"">
        <div class=""loader"">
            <svg class=""circular"" viewBox=""25 25 50 50"">
                <circle class=""path"" cx=""50"" cy=""50"" r=""20"" fill=""none"" stroke-width=""3"" stroke-miterlimit=""10"" />
            </svg>
        </div>
    </div>
    <div id=""main-wrapper"">
        ");
#nullable restore
#line 17 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
   Write(await Html.PartialAsync("~/Views/AdminLayoutPartial/TopBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
   Write(await Html.PartialAsync("~/Views/AdminLayoutPartial/SidebarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"content-body\">\r\n            <div class=\"container-fluid mt-3\">\r\n                ");
#nullable restore
#line 21 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 24 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
   Write(await Html.PartialAsync("~/Views/AdminLayoutPartial/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\AdminLayout.cshtml"
Write(await Html.PartialAsync("~/Views/AdminLayoutPartial/ScriptPartial.cshtml"));

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
            WriteLiteral("\r\n</html>");
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
