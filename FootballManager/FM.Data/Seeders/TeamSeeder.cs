using FM.Data.Entities;

namespace FM.Data.Seeders;
public class TeamSeeder : ISeeder<Team>
{
	private int idCounter;

	public TeamSeeder()
	{
		idCounter = -1;
	}

	public IEnumerable<Team> Seed()
	{
		return [
			new Team()
			{
				Id = idCounter--,
				Name = "Barcelona",
				City = "Barcelona",
				Earnings = 13000000000
			},
			new Team()
			{
				Id = idCounter--,
				Name = "Real Madrid",
				City = "Madrid",
				Earnings = 16000000000
			},
			new Team()
			{
				Id = idCounter--,
				Name = "Porto",
				City = "Porto",
				Earnings = 2000000000
			},
			new Team()
			{
				Id = idCounter--,
				Name = "Manchester City",
				City = "Manchester",
				Earnings = 14000000000
			},
			new Team()
			{
				Id = idCounter--,
				Name = "Levski Sofia",
				City = "Sofia",
				Earnings = 5000000
			},
		];
	}
}
