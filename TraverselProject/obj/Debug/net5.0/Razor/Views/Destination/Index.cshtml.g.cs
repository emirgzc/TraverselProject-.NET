#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a9394fba9a2b346d4190af2fa0e1f5a1d75f2ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_Index), @"mvc.1.0.view", @"/Views/Destination/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a9394fba9a2b346d4190af2fa0e1f5a1d75f2ef", @"/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff86cbbc47abc82ece24bbd528f789cebba8973", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""w3l-about-breadcrumb text-left"">
	<div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
		<div class=""container"">
			<h2 class=""title"">Destinations </h2>
			<ul class=""breadcrumbs-custom-path mt-2"">
				<li><a href=""/Default/Index/"">Ana Sayfa</a></li>
				<li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rotalar </li>
			</ul>
		</div>
	</div>
</section>
<!-- //about breadcrumb -->
<!--  Work gallery section -->
<section class=""grids-1 py-5"">
	<div class=""grids py-lg-5 py-md-4"">
		<div class=""container"">
			<h3 class=""hny-title mb-5"">Tur Rotaları</h3>
			<div class=""row"">				
");
#nullable restore
#line 28 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-6 mt-lg-5 mt-4\">\r\n\t\t\t\t\t\t<div class=\"column\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 910, "\"", 968, 2);
            WriteAttributeValue("", 917, "/Destination/DestinationDetails/", 917, 32, true);
#nullable restore
#line 32 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
WriteAttributeValue("", 949, item.DestinationID, 949, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 974, "\"", 996, 1);
#nullable restore
#line 32 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
WriteAttributeValue("", 980, item.CoverImage, 980, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 997, "\"", 1003, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n\t\t\t\t\t\t\t<div class=\"info\">\r\n\t\t\t\t\t\t\t\t<h4 class=\"mt-3\"><a href=\"blog-single.html\">");
#nullable restore
#line 34 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
                                                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 35 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
                              Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<div class=\"dst-btm\">\r\n\t\t\t\t\t\t\t\t\t<h6");
            BeginWriteAttribute("class", " class=\"", 1203, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral("> Başlayan Fiyatlarla </h6>\r\n\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 38 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 43 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
