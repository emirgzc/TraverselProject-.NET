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
	public class ApiMovieController : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<ApiMovieModel> apiMovies = new List<ApiMovieModel>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "71e77864a6mshb46790049b341a5p1c7841jsnd0d90b38799b" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				apiMovies = JsonConvert.DeserializeObject<List<ApiMovieModel>>(body);
				return View(apiMovies);
			}

		}

	}
}
