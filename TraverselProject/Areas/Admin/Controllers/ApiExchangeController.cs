using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using TraverselProject.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraverselProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiExchangeModel> apiExchangeModels = new List<ApiExchangeModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://apidojo-booking-v1.p.rapidapi.com/currency/get-exchange-rates?base_currency=TRY&languagecode=en-us"),
                Headers =
    {
        { "X-RapidAPI-Key", "71e77864a6mshb46790049b341a5p1c7841jsnd0d90b38799b" },
        { "X-RapidAPI-Host", "apidojo-booking-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ApiExchangeModel>(body);
                return View(values.exchange_rates);
            }
        }
    }
}
