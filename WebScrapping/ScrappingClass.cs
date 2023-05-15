using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebScrapping
{
	public class ScrappingClass
	{
		private static async Task<string> CallUrl(string fullUrl)
		{
			HttpClient client = new HttpClient();
			var response = await client.GetStringAsync(fullUrl);
			return response;

		}

		public IActionResult Index()
		{
			string url = "https://en.wikipedia.org/wiki/List_of_programmers";
			var response = CallUrl(url).Result;
			return View();
		}

	}
}
