#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9923c4fb42d251c91e8d65193105fff8106ae29d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9923c4fb42d251c91e8d65193105fff8106ae29d", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff86cbbc47abc82ece24bbd528f789cebba8973", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
  
	ViewData["Title"] = "DestinationDetails";
	Layout = "~/Views/Shared/AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-about-breadcrumb text-left"">
	<div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
		<div class=""container"">
			<h2 class=""title"">Single Page</h2>
			<ul class=""breadcrumbs-custom-path mt-2"">
				<li><a href=""#url"">Home</a></li>
				<li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Single Post </li>
			</ul>
		</div>
	</div>
</section>

");
#nullable restore
#line 20 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""py-5 w3l-homeblock1 text-center"">
		<div class=""container mt-md-3"">
			<h3 class=""blog-desc-big text-center mb-4"">
				Your Blog Posts are Boring? Here are 9 Tips for
				Making your Writing more Interesting
			</h3>
			<div class=""blog-post-align"">
				<div class=""blog-post-img"">
					<a href=""#""><img");
            BeginWriteAttribute("src", " src=\"", 916, "\"", 939, 1);
#nullable restore
#line 30 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 922, item.Guide.Image, 922, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 940, "\"", 946, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle img-fluid\" /></a>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"blog-post-info\">\r\n\t\t\t\t\t<div class=\"author align-items-center mb-1\">\r\n\t\t\t\t\t\t<a href=\"#\">");
#nullable restore
#line 34 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
                               Write(item.Guide.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<ul class=\"blog-meta\">\r\n\t\t\t\t\t\t<li class=\"meta-item blog-lesson\">\r\n\t\t\t\t\t\t\t<span class=\"meta-value\"> ");
#nullable restore
#line 38 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
                                                  Write(((DateTime)item.Date).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
						</li>
						<li class=""meta-item blog-students"">
							<span class=""meta-value""> 6min read</span>
						</li>
					</ul>
				</div>
			</div>
		</div>
	</div>
	<section class=""blog-post-main w3l-homeblock1"">
		<!--/blog-post-->
		<div class=""blog-content-inf pb-5"">
			<div class=""container pb-lg-4"">
				<div class=""single-post-image"">
					<div class=""post-content"">
						<img");
            BeginWriteAttribute("src", " src=\"", 1703, "\"", 1720, 1);
#nullable restore
#line 54 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 1709, item.Image, 1709, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"radius-image img-fluid mb-5\"");
            BeginWriteAttribute("alt", " alt=\"", 1757, "\"", 1763, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"single-post-content\">\r\n\r\n\t\t\t\t\t<p class=\"mb-4\">");
#nullable restore
#line 59 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

					<div class=""d-grid left-right mt-5 pb-md-5"">
						<div class=""buttons-singles tags"">
							<h4>Tags :</h4>
							<a href=""#blog-tag"">Travel</a>
							<a href=""#blog-tag"">Culture</a>
							<a href=""#blog-tag"">Hotel</a>
							<a href=""#blog-tag"">Food</a>
						</div>
						<div class=""buttons-singles"">
							<h4>Share :</h4>
							<a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
							<a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
							<a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
							<a href=""#blog-share""><span class=""fa fa-pinterest-p"" aria-hidden=""true""></span></a>
						</div>
					</div>

					<div class=""author-card mt-5"">
						<div class=""row align-items-center"">
							<div class=""col-sm-3 col-6"">
								<div>
									<img");
            BeginWriteAttribute("src", " src=\"", 2768, "\"", 2791, 1);
#nullable restore
#line 82 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 2774, item.Guide.Image, 2774, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2792, "\"", 2798, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle img-fluid\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n\t\t\t\t\t\t\t\t<h3 class=\"mb-3 title\">");
#nullable restore
#line 86 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
                                                  Write(item.Guide.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 88 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
                               Write(item.Guide.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</p>
								<ul class=""author-icons mt-4"">
									<li>
										<a class=""facebook"" href=""#url"">
											<span class=""fa fa-facebook""
												  aria-hidden=""true""></span>
										</a>
									</li>
									<li>
										<a class=""twitter"" href=""#url"">
											<span class=""fa fa-twitter""
												  aria-hidden=""true""></span>
										</a>
									</li>
									<li>
										<a class=""google"" href=""#url"">
											<span class=""fa fa-google-plus""
												  aria-hidden=""true""></span>
										</a>
									</li>
									<li>
										<a class=""linkedin"" href=""#url"">
											<span class=""fa fa-linkedin""
												  aria-hidden=""true""></span>
										</a>
									</li>
									<li>
										<a class=""github"" href=""#url"">
											<span class=""fa fa-github""
												  aria-hidden=""true""></span>
										</a>
									</li>
									<li>
										<a class=""dribbble"" href=""#url"">
											<span class=""fa fa-dribbble""
			");
            WriteLiteral("\t\t\t\t\t\t\t\t\t  aria-hidden=\"true\"></span>\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 133 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("CommentList", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 136 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n");
#nullable restore
#line 143 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Views\Destination\DestinationDetails.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591