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
	public required int TeamId { get; set; }
	[Required]
	[Column(TypeName = "decimal(19, 2)")]
	public required decimal TransferValue { get; set; }
	[ForeignKey(nameof(AthleteId))]
	public Athlete Athlete { get; set; }
	[ForeignKey(nameof(TeamId))]
	public Team Team { get; set; }
	public DateTime CreatedAt { get; set; }
}
