using FM.Services.Messaging.Authentication;

namespace FM.Services.Interfaces
{
	public interface IJWTAuthenticationsManager
	{
		Task<JWTResponseOrError> AuthenticateAsync(string username, string password);

		Task<JWTResponseOrError> RegisterUserAsync(string username, string password);

		Task<JWTResponseOrError> SoftDeleteUserAsync(string username);
	}
}
