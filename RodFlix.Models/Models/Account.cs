using System.ComponentModel.DataAnnotations;


namespace RodFlix.Models
{
	public class Account
	{
		[Key]
		public int IdAccount { get; set; }
		[Required]
		[MaxLength(255)]
		public string Email { get; set; }
		[Required]
		[MaxLength(127)]
		public string Senha { get; set; }
		



	}
}
