#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Comment\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579f88b6cc6a21fdeccefeb75d42d1a31a848448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_AddComment), @"mvc.1.0.view", @"/Views/Comment/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579f88b6cc6a21fdeccefeb75d42d1a31a848448", @"/Views/Comment/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff86cbbc47abc82ece24bbd528f789cebba8973", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"leave-comment-form mt-5\" id=\"reply\">\r\n\t<h4 class=\"side-title mb-2\">Bir Yorum Bırakın</h4>\r\n\t<p class=\"mb-4\">İşaretli alanları doldurmanız gerekmektedir *</p>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579f88b6cc6a21fdeccefeb75d42d1a31a8484485066", async() => {
                WriteLiteral("\r\n\r\n\t\t<div class=\"form-group\">\r\n\t\t\t<textarea name=\"CommentContent\" class=\"form-control\" placeholder=\"Yorumunuz *\"");
                BeginWriteAttribute("required", " required=\"", 358, "\"", 369, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n\t\t\t\t\t  spellcheck=\"false\"></textarea>\r\n\t\t</div>\r\n\r\n\t\t<div class=\"form-group col-lg-6\">\r\n\t\t\t<input type=\"hidden\" name=\"DestinationID\"");
                BeginWriteAttribute("value", " value=\"", 504, "\"", 522, 1);
#nullable restore
#line 14 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Comment\AddComment.cshtml"
WriteAttributeValue("", 512, ViewBag.i, 512, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"ID\"");
                BeginWriteAttribute("required", " required=\"", 561, "\"", 572, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t</div>\r\n\t\t\r\n\t\t<div class=\"form-group col-lg-6\">\r\n\t\t\t<input type=\"hidden\" name=\"AppUserId\"");
                BeginWriteAttribute("value", " value=\"", 667, "\"", 690, 1);
#nullable restore
#line 18 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Comment\AddComment.cshtml"
WriteAttributeValue("", 675, ViewBag.userID, 675, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"ID\"");
                BeginWriteAttribute("required", " required=\"", 729, "\"", 740, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t</div>\r\n\r\n\t\t<div class=\"submit text-right\">\r\n\t\t\t<button class=\"btn btn-style btn-primary\">Yorum Yap </button>\r\n\t\t</div>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
