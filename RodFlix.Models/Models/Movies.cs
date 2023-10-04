using System.ComponentModel.DataAnnotations;

namespace RodFlix.Models
{
	public class Movies
	{
		[Key]
		public int IdMovie { get; set; }
		[Required]
		public string Title { get; set; }
		public string? Img { get; set; }
		[MaxLength(255)]
		public string? Description { get; set; }
		[Range(1,1000)]
		public ushort LengthMinutes { get; set; } 
		public byte? Categoria1 { get; set; }
		public byte? Categoria2 { get; set; }
		public byte? Categoria3 { get; set; }
		public byte? Categoria4 { get; set; }
		public byte? Categoria5 { get; set; }
		public byte? Categoria6 { get; set; }
		

	}
}
