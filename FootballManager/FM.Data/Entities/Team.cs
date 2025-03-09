using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.Data.Entities;

public class Team
{
	[Key]
	public int Id { get; set; }
	public int UserId { get; set; }
	public string Name { get; set; }

	[ForeignKey(nameof(UserId))]
	public User User { get; set; }
}
