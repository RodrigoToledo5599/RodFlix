using Microsoft.EntityFrameworkCore;
using RodFlix.Models;

namespace RodFlix.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> Options): base(Options) { }
		public DbSet <Movies> Movies { get; set; }
		public DbSet <DmCategories> DmCategories { get; set; }
		public DbSet <Account> Account { get; set; }


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
				new DmCategories { IdDmCategories = 11, CategorieName = "Romance"},
				new DmCategories { IdDmCategories = 12, CategorieName = "Zombie"},
				new DmCategories { IdDmCategories = 13, CategorieName = "Comédia"}
				);
			
			modelBuilder.Entity<Movies>().HasData(
				new Movies { IdMovie = 1, Title = "Carga Explosiva", LengthMinutes=103},
				new Movies { IdMovie = 2, Title = "Sonic o filme", LengthMinutes = 99 },
				new Movies { IdMovie = 3, Title = "Exterminador do futuro", LengthMinutes = 130 },
				new Movies { IdMovie = 4, Title = "One piece film red", LengthMinutes = 100 },
				new Movies { IdMovie = 5, Title = "Avatar", LengthMinutes = 140 },
				new Movies { IdMovie = 6, Title = "Debi e Loide 2", LengthMinutes = 96 },
				new Movies { IdMovie = 7, Title = "Zohan", LengthMinutes = 90 },
				new Movies { IdMovie = 8, Title = "Senhor dos anéis 2", LengthMinutes = 180 },
				new Movies { IdMovie = 9, Title = "Drive", LengthMinutes = 103 },
				new Movies { IdMovie = 10, Title = "Taxi Driver", LengthMinutes = 110 },
				new Movies { IdMovie = 11, Title = "Blade runner o caçador de androides", LengthMinutes = 160},
				new Movies { IdMovie = 12, Title = "Homem aranha 2", LengthMinutes = 132 },
				new Movies { IdMovie = 13, Title = "Iron man", LengthMinutes = 105},
				new Movies { IdMovie = 14, Title = "Velozes e furiosos", LengthMinutes = 103 },
				new Movies { IdMovie = 15, Title = "Rocky", LengthMinutes = 100 },
				new Movies { IdMovie = 16, Title = "Rambo the first blood", LengthMinutes = 90 },
				new Movies { IdMovie = 17, Title = "Transformers", LengthMinutes = 125 },
				new Movies { IdMovie = 18, Title = "Carga Explosiva 2", LengthMinutes = 98 },
				new Movies { IdMovie = 19, Title = "Kung Fu Panda 3", LengthMinutes = 99 }

				);

			modelBuilder.Entity<Account>().HasData(
				
				new Account {IdAccount = 1, Email = "123@gmail.com", Senha = "123"},
				new Account {IdAccount = 2, Email = "emailgenerico@gmail.com", Senha = "senha123"}
				);
		}
	}
}