using FM.Data.Entities;
using FM.Data.Seeders;
using Microsoft.EntityFrameworkCore;

namespace FM.Data.Contexts
{
	/// <summary>
	/// Movie database context.
	/// </summary>
	public class FootballManagerDbContext : DbContext
	{
		/// <summary>
		/// Gets or sets movie dbset collection.
		/// </summary>
		public DbSet<Athlete> Athletes { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<AthleteTeam> AthleteTeam { get; set; }

		public FootballManagerDbContext() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="FootballManagerDbContext"/> class.
		/// </summary>
		/// <param name="options">Database context options.</param>
		public FootballManagerDbContext(DbContextOptions<FootballManagerDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Athlete>().HasData(new AthletesSeeder().Seed());
		}

	}
}
