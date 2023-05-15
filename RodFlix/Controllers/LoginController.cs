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
		#region "Pagina de Login"
		public IActionResult Index(string email, string senha)
		{
			bool logadoOuNao = CheckUpDeLoginGet(email, senha);

			if (logadoOuNao == false)
				return View();

			else
				return Redirect("/MainPage/Index/");
		}
		[HttpGet]
		public bool CheckUpDeLoginGet(string email, string senha)
		{
			conta = _db.Account.Where(c => c.Email == email).FirstOrDefault();

			if (conta == null || conta.Email == null || conta.Senha == null)
				return false;

			else if (conta.Email != email || conta.Senha != senha)
				return false;

			else return true;
		}
		#endregion

		#region "Pagina de Cadastro"

		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar(Account Conta)
		{
			_db.Account.Add(Conta);
			_db.SaveChanges();
			return View();
		}

		#endregion


		
	}
}
