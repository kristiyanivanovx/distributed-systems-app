namespace FM.Data.Seeders;
public interface ISeeder<T>
{
	public IEnumerable<T> Seed() { throw new NotImplementedException(); }
}
