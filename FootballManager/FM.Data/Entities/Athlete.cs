using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
		AttackingMidfield,
		DefensiveMidfield,
		Forward,
		LeftWing,
		RightWing,
	}

	// Team, Athlete, Match, Club
	[Key]
	public int Id { get; set; }
	public int TeamId { get; set; }
	[Required]
	[Column(TypeName = "varchar(30)")]
	public required string FirstName { get; set; }
	[Column(TypeName = "varchar(30)")]
	public string LastName { get; set; }
	[Column(TypeName = "varchar(30)")]
	public required string Nationality { get; set; }
	public AthletePosition Position { get; set; }
	[Column(TypeName = "decimal(19, 2)")]
	public decimal MarketValue { get; set; }
	public bool IsActive { get; set; } = true;
	public DateTime CreatedAt { get; set; }
	[ForeignKey(nameof(TeamId))]
	public Team Team { get; set; }

}
