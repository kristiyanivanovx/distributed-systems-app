namespace FM.Data.Entities;

public class Team
{
	public int Id { get; set; }
	public string Name { get; set; }
	public User User { get; set; }
}
