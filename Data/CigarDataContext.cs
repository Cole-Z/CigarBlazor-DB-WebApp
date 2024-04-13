using Microsoft.EntityFrameworkCore;

namespace Cigars.Data
{
	public class CigarDataContext : DbContext // extend db context from EF Core
	{
		protected readonly IConfiguration _configuration;

		public CigarDataContext(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(_configuration.GetConnectionString("CigarDB")); // connection string app settings.json
		}

		public DbSet<Cigar> Cigar { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cigar>().ToTable("cigar_set");

			modelBuilder.Entity<Cigar>().HasData(
				new Cigar { Id = 1, Brand = "Drew Estate", Name = "Liga Privada No. 9", Wrapper = "Maduro Nicaraguan", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 23.99 },
				new Cigar { Id = 2, Brand = "Arturo Fuente", Name = "OpusX", Wrapper = "Maduro Dominican", Origin = "Dominican", Binder = "Dominican", Filler = "Dominican", Body = "Full", Price = 29.99 },
				new Cigar { Id = 3, Brand = "Padron", Name = "1926 Serie", Wrapper = "Natural Nicaraguan", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 34.5 },
				new Cigar { Id = 4, Brand = "Cohiba", Name = "Behike", Wrapper = "Colorado Cuban", Origin = "Cuban", Binder = "Cuban", Filler = "Cuban", Body = "Medium-Full", Price = 45.75 },
				new Cigar { Id = 5, Brand = "Montecristo", Name = "No. 2", Wrapper = "Maduro Cuban", Origin = "Cuban", Binder = "Cuban", Filler = "Cuban", Body = "Medium", Price = 22.75 },
				new Cigar { Id = 6, Brand = "Rocky Patel", Name = "Vintage 1990", Wrapper = "Sumatra", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Medium", Price = 18.5 },
				new Cigar { Id = 7, Brand = "Romeo y Julieta", Name = "Churchill", Wrapper = "Maduro Dominican", Origin = "Dominican", Binder = "Dominican", Filler = "Dominican", Body = "Medium-Full", Price = 21.25 },
				new Cigar { Id = 8, Brand = "Oliva", Name = "Serie V", Wrapper = "Sun Grown Nicaraguan", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 19.99 },
				new Cigar { Id = 9, Brand = "La Flor Dominicana", Name = "Andalusian Bull", Wrapper = "Colorado Ecuadorian", Origin = "Dominican", Binder = "Dominican", Filler = "Dominican", Body = "Full", Price = 28.99 },
				new Cigar { Id = 10, Brand = "Black Works Studio", Name = "Killer Bee", Wrapper = "Maduro Ecuadorian", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 13.75 },
				new Cigar { Id = 11, Brand = "Black Works Studio", Name = "NBK", Wrapper = "San Andres Mexican", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 14.5 },
				new Cigar { Id = 12, Brand = "Black Label Trading Company", Name = "Lawless", Wrapper = "Pennsylvania Broadleaf", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 11.75 },
				new Cigar { Id = 13, Brand = "Black Works Studio", Name = "Green Hornet", Wrapper = "Candela", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Medium", Price = 12.99 },
				new Cigar { Id = 14, Brand = "Black Label Trading Company", Name = "Royalty", Wrapper = "Connecticut Broadleaf", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Medium-Full", Price = 10.5 },
				new Cigar { Id = 15, Brand = "Black Label Trading Company", Name = "Bishops Blend", Wrapper = "Maduro Nicaraguan", Origin = "Nicaraguan", Binder = "Nicaraguan", Filler = "Nicaraguan", Body = "Full", Price = 11.99 });
		}
	}
}
