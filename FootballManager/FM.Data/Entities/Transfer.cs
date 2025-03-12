using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.Data.Entities;
public class Transfer
{
	[Key]
	public int Id { get; set; }
	[Required]
	public required int AthleteId { get; set; }
	[Required]
	public required int NewTeamId { get; set; }
	[Required]
	public required int OldTeamId { get; set; }
	[Required]
	[Column(TypeName = "decimal(19, 2)")]
	public required decimal TransferValue { get; set; }
	public bool IsActive { get; set; } = true;
	[ForeignKey(nameof(AthleteId))]
	public Athlete Athlete { get; set; }
	[ForeignKey(nameof(NewTeamId))]
	public Team NewTeam { get; set; }
	[ForeignKey(nameof(OldTeamId))]
	public Team OldTeam { get; set; }
	public DateTime CreatedAt { get; set; }
}
