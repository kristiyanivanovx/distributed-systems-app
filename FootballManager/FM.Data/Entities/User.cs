using System.ComponentModel.DataAnnotations;

namespace FM.Data.Entities;
public class User
{
	[Key]
	public int Id { get; set; }

	[Required]
	public required string Username { get; set; }

	[Required]
	public required string Password { get; set; }

	public bool IsActive { get; set; } = true;
}
