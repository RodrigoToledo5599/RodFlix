using Microsoft.AspNetCore.Mvc;
using RodFlix.Data;
using RodFlix.Models;

namespace RodFlix.Controllers
{
	[BindProperties]
	public class LoginController : Controller
	{
		public readonly AppDbContext _db;
		private Account? conta;

		public LoginController(AppDbContext db)
		{
			_db = db;
		}

		public IActionResult Index(string email, string senha)
		{
			bool logadoOuNao = CheckUpDeLoginPost(email, senha);

			if (logadoOuNao == false)
				return View();

			else
				return Redirect("/MainPage/Index/");
		}
		[HttpGet]
		public bool CheckUpDeLoginPost(string email, string senha)
		{
			conta = _db.Account.Where(c => c.Email == email).FirstOrDefault();

			if (conta == null || conta.Email == null || conta.Senha == null)
				return false;

			else if (conta.Email != email || conta.Senha != senha)
				return false;

			else return true;
		}
		
	}
}
