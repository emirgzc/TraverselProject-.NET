#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2839721085140d74e21a8a8a65b20fec40d78c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Feature_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Feature/Default.cshtml")]
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
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2839721085140d74e21a8a8a65b20fec40d78c4f", @"/Views/Shared/Components/Feature/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff86cbbc47abc82ece24bbd528f789cebba8973", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Feature_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""best-rooms py-5"">
	<div class=""container py-md-5"">
		<div class=""ban-content-inf row"">
			<div class=""maghny-gd-1 col-lg-6"">
				<div class=""maghny-grid"">
					<figure class=""effect-lily border-radius  m-0"">
						<img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 307, "\"", 342, 1);
#nullable restore
#line 10 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
WriteAttributeValue("", 313, Model.FirstOrDefault().Image, 313, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 343, "\"", 349, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t<figcaption>\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 13 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
                               Write(Model.FirstOrDefault().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 14 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
                              Write(Model.FirstOrDefault().Descrtipton);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t</figcaption>\r\n\t\t\t\t\t</figure>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"maghny-gd-1 col-lg-6 mt-lg-0 mt-4\">\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
                     for (int i = 1; i <= 4; i++)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"maghny-gd-1 col-6 mt-4\">\r\n\t\t\t\t\t\t\t<div class=\"maghny-grid\">\r\n\t\t\t\t\t\t\t\t<figure class=\"effect-lily border-radius\">\r\n\t\t\t\t\t\t\t\t\t<img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 847, "\"", 868, 1);
#nullable restore
#line 28 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
WriteAttributeValue("", 853, Model[i].Image, 853, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 869, "\"", 875, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t<figcaption>\r\n\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 31 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
                                           Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 32 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
                                          Write(Model[i].Descrtipton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t</figcaption>\r\n\t\t\t\t\t\t\t\t</figure>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 39 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Shared\Components\Feature\Default.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591