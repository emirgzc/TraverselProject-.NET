#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09eaab1bf4b8e77a502f780e6b86653196c4ba7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\_ViewImports.cshtml"
using TraverselProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\_ViewImports.cshtml"
using TraverselProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09eaab1bf4b8e77a502f780e6b86653196c4ba7f", @"/Areas/Member/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235f01efb341edd323b2fffcb9511fbecb080bc9", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <div class=""card mb-4"">
            <div class=""card-header pb-0"">
                <h6>Aktif Tur Rotalarımız</h6>
            </div>
            <div class=""card-body px-0 pt-0 pb-2"">
                <div class=""table-responsive p-0"">
                    <table class=""table align-items-center mb-0"">
                        <thead>
                            <tr>
                                <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">#</th>
                                <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Resim</th>
                                <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Süre</th>
                                <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Kapasite</th>
                                <th class=""text-center text-uppercase text");
            WriteLiteral(@"-secondary text-xxs font-weight-bolder opacity-7"">Fiyat</th>
                                <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Detaylar</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"align-middle text-center text-sm\">\r\n                                        <span class=\"badge badge-sm bg-gradient-success\">");
#nullable restore
#line 35 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                                                                                    Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </td>
                                    <td>
                                        <div class=""d-flex px-2 py-1"">
                                            <div>
                                                <img");
            BeginWriteAttribute("src", " src=\"", 2062, "\"", 2079, 1);
#nullable restore
#line 40 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
WriteAttributeValue("", 2068, item.Image, 2068, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""avatar avatar-sm me-3"" alt=""user1"">
                                            </div>
                                            <div class=""d-flex flex-column justify-content-center"">
                                                <h6 class=""mb-0 text-sm"">");
#nullable restore
#line 43 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                                                                    Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
                                        <p class=""text-xs text-center font-weight-bold mb-0"">");
#nullable restore
#line 48 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                                                                                        Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td class=\"align-middle text-center text-sm\">\r\n                                        <span class=\"badge badge-sm bg-gradient-success\">");
#nullable restore
#line 51 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                                                                                    Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </td>\r\n                                    <td class=\"align-middle text-center\">\r\n                                        <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 54 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ₺</span>
                                    </td>
                                    <td class=""align-middle text-center"">
                                        <a href=""#"" class=""btn-sm btn-info"">Detaylar</a>
                                    </td>
                                </tr>
");
#nullable restore
#line 60 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Destination\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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