using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.Data.Entities;
public class AthleteTeam
{
	[Key]
	public int Id { get; set; }
	public int AthleteId { get; set; }
	public int TeamId { get; set; }

	[ForeignKey(nameof(AthleteId))]
	public Athlete Athlete { get; set; }
	[ForeignKey(nameof(TeamId))]
	public Team Team { get; set; }
}
