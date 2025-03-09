using FM.Data.Entities;

namespace FM.Data.Seeders;
public class AthleteTeamSeeder : ISeeder<AthleteTeam>
{
	private int idCounter = -1;
	public IEnumerable<AthleteTeam> Seed()
	{
		List<AthleteTeam> athleteTeams = new List<AthleteTeam>();

		Random rand = new Random();

		for (int i = -1; i > -49; i--)
		{
			athleteTeams.Add(new AthleteTeam()
			{
				Id = idCounter--,
				AthleteId = i,
				TeamId = rand.Next(1, 6) * -1
			});
		}

		return athleteTeams;
	}
}
