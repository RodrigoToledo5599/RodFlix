using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;



namespace RodFlix.Controllers
{
	public class TestingController : Controller
	{

		public static async Task<string> CallUrl(string fullUrl)
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
		/*
		private List<string> ParseHtml(string html)
		{
			HtmlDocument htmlDoc = new HtmlDocument();
			htmlDoc.LoadHtml(html);

			var programmerLinks = htmlDoc.DocumentNode.Descendants("li").
				Where(node => !node.GetAttributeValue("class","").Contains("tocsection")).ToList();

			List<string> wikiLink = new List<string>();

			foreach (var link in programmerLinks)
			{
				if (link.FirstChild.Attributes.Count > 0) wikiLink.Add("");
			}

		}
		*/



	}


}
