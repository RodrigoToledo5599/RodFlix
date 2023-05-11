using Microsoft.EntityFrameworkCore;
using RodFlix.Models;

namespace RodFlix.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> Options): base(Options) { }
		public DbSet <Movies> Movies { get; set; }
		public DbSet <DmCategories> DmCategories { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DmCategories>().HasData(
				new DmCategories { IdDmCategories = 1, CategorieName = "Ação"},
				new DmCategories { IdDmCategories = 2, CategorieName = "Drama"},
				new DmCategories { IdDmCategories = 3, CategorieName = "Terror"},
				new DmCategories { IdDmCategories = 4, CategorieName = "Horror"},
				new DmCategories { IdDmCategories = 5, CategorieName = "Infantil"},
				new DmCategories { IdDmCategories = 6, CategorieName = "Aventura"},
				new DmCategories { IdDmCategories = 7, CategorieName = "Carros"},
				new DmCategories { IdDmCategories = 8, CategorieName = "Documentario"},
				new DmCategories { IdDmCategories = 9, CategorieName = "Anime"},
				new DmCategories { IdDmCategories = 10, CategorieName = "80s"},
				new DmCategories { IdDmCategories = 11, CategorieName = "Romance"}
				


				);
		}
	}
}
