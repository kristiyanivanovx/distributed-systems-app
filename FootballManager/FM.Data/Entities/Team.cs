using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.Data.Entities;

public class Team
{
	[Key]
	public int Id { get; set; }

	[Required]
	[Column(TypeName = "varchar(30)")]
	public required string Name { get; set; }

	[Required]
	[Column(TypeName = "varchar(20)")]
	public required string City { get; set; }

	[Column(TypeName = "decimal(19, 2)")]
	public decimal Earnings { get; set; }

	public bool IsActive { get; set; } = true;

	public DateTime CreatedAt { get; set; }
}
