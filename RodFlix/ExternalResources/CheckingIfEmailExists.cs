using System.Collections.Generic;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace RodFlix.ExternalResources
{
	public class CheckingIfEmailExists
	{
		public ScrapingBrowser _scrapingbrowser = new ScrapingBrowser();
		public HtmlNode GetHtml(string url)
		{
			WebPage webPage = _scrapingbrowser.NavigateToPage(new Uri(url), HttpVerb.Get,@"");
			return webPage.Html;
		}

	}
}
