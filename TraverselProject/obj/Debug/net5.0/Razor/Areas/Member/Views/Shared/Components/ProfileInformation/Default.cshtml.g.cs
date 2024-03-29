#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Shared\Components\ProfileInformation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b28bc53c2ab774c2b723f9b78a7667685068188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Shared_Components_ProfileInformation_Default), @"mvc.1.0.view", @"/Areas/Member/Views/Shared/Components/ProfileInformation/Default.cshtml")]
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
#line 3 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b28bc53c2ab774c2b723f9b78a7667685068188", @"/Areas/Member/Views/Shared/Components/ProfileInformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235f01efb341edd323b2fffcb9511fbecb080bc9", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Shared_Components_ProfileInformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.AppUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <div class=""row"">
                <div class=""col-md-8 d-flex align-items-center"">
                    <h6 class=""mb-0"">Profil Bilgileri</h6>
                </div>
                <div class=""col-md-4 text-end"">
                    <a href=""/Member/Profile/Index/"" target=""_blank"">
                        <i class=""fas fa-user-edit text-secondary text-sm"" data-bs-toggle=""tooltip"" data-bs-placement=""top"" title=""Edit Profile""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""card-body p-3"">
            <p class=""text-sm"">                
                Traversal rezervasyon üye paneline hoşgeldiniz. Sol tarafta bulunan menüler üzerinden geçmiş rezervasyonlarınızı,
                onaylanmayan rezervasyonlarınızı ve iletişim detaylarını görebilirsiniz.
            </p>
            <hr class=""horizontal gray-light my-4"">");
            WriteLiteral("\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item border-0 ps-0 pt-0 text-sm\"><strong class=\"text-dark\">Ad Soyad:</strong> &nbsp; ");
#nullable restore
#line 25 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Shared\Components\ProfileInformation\Default.cshtml"
                                                                                                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Shared\Components\ProfileInformation\Default.cshtml"
                                                                                                                                  Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Telefon:</strong> &nbsp; ");
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Shared\Components\ProfileInformation\Default.cshtml"
                                                                                                                Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Mail Adresi:</strong> &nbsp; ");
#nullable restore
#line 27 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Shared\Components\ProfileInformation\Default.cshtml"
                                                                                                                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""list-group-item border-0 ps-0 text-sm""><strong class=""text-dark"">Konum:</strong> &nbsp; Türkiye</li>
                <li class=""list-group-item border-0 ps-0 pb-0"">
                    <strong class=""text-dark text-sm"">Sosyal Medya:</strong> &nbsp;
                    <a class=""btn btn-facebook btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-facebook fa-lg""></i>
                    </a>
                    <a class=""btn btn-twitter btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-twitter fa-lg""></i>
                    </a>
                    <a class=""btn btn-instagram btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-instagram fa-lg""></i>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.AppUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
