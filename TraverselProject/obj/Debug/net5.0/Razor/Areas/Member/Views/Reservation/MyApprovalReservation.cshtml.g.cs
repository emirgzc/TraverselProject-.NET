#pragma checksum "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e4f94ac0450ae551a19de461b97996a76d3be24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyApprovalReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
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
#line 1 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4f94ac0450ae551a19de461b97996a76d3be24", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235f01efb341edd323b2fffcb9511fbecb080bc9", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyApprovalReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
  
	ViewData["Title"] = "MyApprovalReservation";
	Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Onay Bekleyen Rezervasyonlarım</h3>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"container mt-5\">\r\n\t\t<h4 style=\"color:crimson\">Onay Bekleyen rezervasyonunuz bulunmamaktadır..</h4>\r\n\t</div>\r\n");
#nullable restore
#line 17 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
}
else{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""row"">
		<div class=""col-12"">
			<div class=""card mb-4"">
				<div class=""card-body px-0 pt-0 pb-2"">
					<div class=""table-responsive p-0"">
						<table class=""table align-items-center mb-0"">
							<thead>
								<tr>
									<th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">#</th>
									<th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Lokasyon</th>
									<th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Kişi Sayısı</th>
									<th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Tarih</th>
									<th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Durum</th>
								</tr>
							</thead>
							<tbody>
");
#nullable restore
#line 36 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                 foreach (var item in Model)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle text-center\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 40 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                             Write(item.ReservationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<p class=\"text-xs text-center font-weight-bold mb-0\">");
#nullable restore
#line 43 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                            Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<p class=\"text-xs text-center font-weight-bold mb-0\">");
#nullable restore
#line 46 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                            Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle text-center text-sm\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 49 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                              Write(((DateTime)item.ReservationDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"align-middle text-center\">\r\n");
#nullable restore
#line 52 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                             if (item.ReserStatusID == 1)
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge badge-sm bg-gradient-warning\">");
#nullable restore
#line 54 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                            Write(item.ReserStatus.ReserStatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
											}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 58 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 66 "C:\Users\emirgzc\source\repos\TraverselProject\TraverselProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
