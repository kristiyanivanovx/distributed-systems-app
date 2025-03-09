using FM.Data.Entities;

namespace FM.Data.Seeders;
public class UsersSeeder : ISeeder<User>
{
	private int idCounter = -1;
	public IEnumerable<User> Seed()
	{
		return [
			new User()
			{
				Id = idCounter--,
				Username = "johndoe",
				Password = "test123"
			}
		];
	}
}
