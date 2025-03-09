namespace FM.Data.Entities;
public class Athlete
{
	public enum AthletePosition
	{
		Goalkeeper,
		RightFullback,
		LeftFullback,
		Centerback,
		CenterMidfield,
		LeftMidfield,
		RightMidfield,
		Forward,
		LeftWing,
		RightWing,
	}

	// Team, Athlete, Match, Club

	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Nationality { get; set; }
	public AthletePosition Position { get; set; }
}
