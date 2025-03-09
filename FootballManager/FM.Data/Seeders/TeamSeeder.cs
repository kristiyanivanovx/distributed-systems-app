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
			
		];
	}
}
