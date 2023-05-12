﻿using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using RodFlix.Data;
using RodFlix.Models;

namespace RodFlix.Controllers
{
	public class MoviesController : Controller
	{
		public readonly AppDbContext _db;
		public MoviesController (AppDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			return View();
		}

	}
}
