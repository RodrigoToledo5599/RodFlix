using System.ComponentModel.DataAnnotations;

namespace RodFlix.Models
{
	public class DmCategories
	{
		[Key]
		public byte IdDmCategories { get; set; }
		[Required]
		[MaxLength(63)]
		public string CategorieName { get; set; }



	}
}
