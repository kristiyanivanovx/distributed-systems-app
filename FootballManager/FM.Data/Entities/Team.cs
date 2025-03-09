using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.Data.Entities;

public class Team
{
	[Key]
	public int Id { get; set; }
	public string Name { get; set; }
	public string City { get; set; }
	[Column(TypeName = "decimal(19, 2)")]
	public decimal Earnings { get; set; }
	public bool IsActive { get; set; } = true;
	public DateTime CreatedAt { get; set; }
}
