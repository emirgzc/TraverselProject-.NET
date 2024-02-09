#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b3fc2abfd7c5055b81142185cf6ab3e260c358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\_ViewImports.cshtml"
using TraverselProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b3fc2abfd7c5055b81142185cf6ab3e260c358", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4fd43ffde7137d96207c8aa6bfc94191f504b7f", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""active-member"">
                    <div class=""table-responsive"">
                        <table class=""table table-xs mb-0"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Görsel</th>
                                    <th>Ad Soyad</th>
                                    <th>Meslek</th>
                                    <th>Durum</th>
                                    <th>Sil</th>
                                    <th>Güncelle</th>
                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 30 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 33 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                       Write(item.GuideID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 1226, "\"", 1243, 1);
#nullable restore
#line 34 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1232, item.Image, 1232, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\"/></td>\r\n                                        <td>");
#nullable restore
#line 35 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><span>");
#nullable restore
#line 36 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                             Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                        <td>\r\n");
#nullable restore
#line 38 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                             if (!item.Status)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 1605, "\"", 1651, 2);
            WriteAttributeValue("", 1612, "/Admin/Guide/ChangeToTrue/", 1612, 26, true);
#nullable restore
#line 40 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1638, item.GuideID, 1638, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Aktif Yap</a>\r\n");
#nullable restore
#line 41 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 1886, "\"", 1933, 2);
            WriteAttributeValue("", 1893, "/Admin/Guide/ChangeToFalse/", 1893, 27, true);
#nullable restore
#line 44 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1920, item.GuideID, 1920, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Pasif Yap</a>\r\n");
#nullable restore
#line 45 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2113, "\"", 2158, 2);
            WriteAttributeValue("", 2120, "/Admin/Guide/DeleteGuide/", 2120, 25, true);
#nullable restore
#line 47 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 2145, item.GuideID, 2145, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-danger\">Sil</a></td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2246, "\"", 2289, 2);
            WriteAttributeValue("", 2253, "/Admin/Guide/EditGuide/", 2253, 23, true);
#nullable restore
#line 48 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 2276, item.GuideID, 2276, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-info\">Güncelle</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Admin\Views\Guide\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<a href=\"/Admin/Guide/AddGuide\" class=\"btn btn-success\">Yeni Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591