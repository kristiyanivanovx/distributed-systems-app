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
		public DbSet<Transfer> Transfers { get; set; }

		public FootballManagerDbContext() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="FootballManagerDbContext"/> class.
		/// </summary>
		/// <param name="options">Database context options.</param>
		public FootballManagerDbContext(DbContextOptions<FootballManagerDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Team>().HasData(new TeamSeeder().Seed()); 
			modelBuilder.Entity<Athlete>().HasData(new AthletesSeeder().Seed());

			modelBuilder.Entity<Athlete>()
				.Property(b => b.CreatedAt)
				.HasDefaultValueSql("getutcdate()");

			modelBuilder.Entity<Team>()
				.Property(b => b.CreatedAt)
				.HasDefaultValueSql("getutcdate()");

			modelBuilder.Entity<Transfer>()
				.Property(b => b.CreatedAt)
				.HasDefaultValueSql("getutcdate()");

			modelBuilder.Entity<User>()
			  .HasIndex(u => u.Username)
			  .IsUnique();
		}
	}
}
