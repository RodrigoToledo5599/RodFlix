using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using RodFlix.Data;
using RodFlix.Models;

namespace RodFlix.Controllers
{
	[BindProperties]
	public class MainPageController : Controller
	{
		public readonly AppDbContext _db;

		public MainPageController (AppDbContext db)
		{
			_db = db;
		}	

		public IActionResult Index()
		{
			List<Movies> movies = _db.Movies.ToList();
			return View(movies);
		}


	}
}
