namespace FM.Services.Interfaces
{
	public interface IJWTAuthenticationsManager
	{
		string? Authenticate(string clientId, string secret);
	}
}
