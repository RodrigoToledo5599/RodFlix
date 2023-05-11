using Microsoft.AspNetCore.Mvc;

namespace RodFlix.Controllers
{
	public class MoviesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
