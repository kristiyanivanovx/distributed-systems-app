using FM.Services.Implementations;
using FM.Services.Interfaces;
using FM.Services.Messaging.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FM.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IJWTAuthenticationsManager _jwtAuthenticationsManager;

		public AuthController(IJWTAuthenticationsManager jwtauthenticationsManager)
		{
			_jwtAuthenticationsManager = jwtauthenticationsManager;
		}

		/// <summary>
		/// Method to authenticate already existing active users.
		/// </summary>
		/// <param name="username">An unique username of the user to be authenticated.</param>
		/// <param name="password">User's password</param>
		/// <returns>An exception if there is error or the created token.</returns>
		[HttpPut]
		public async Task<AuthenticationResponse> Authenticate([FromQuery] string username, [FromQuery] string password)
		{
			JWTResponseOrError response = await _jwtAuthenticationsManager.AuthenticateAsync(username, password);

			if (response?.Token is null)
			{
				return new AuthenticationResponse() { Error = response?.Error?.Message ?? "Unexpected error!" };
			}

			return await Task.FromResult(new AuthenticationResponse() { Token = response.Token });
		}

		/// <summary>
		/// Method to register a new user.
		/// </summary>
		/// <param name="username">An unique username of the user to be registered.</param>
		/// <param name="password">The user's password.</param>
		/// <returns>An exception if there is error or a success message.</returns>
		[HttpPost("register")]
		public async Task<AuthenticationResponse> Register([FromQuery] string username, [FromQuery] string password)
		{
			JWTResponseOrError response = await _jwtAuthenticationsManager.RegisterUserAsync(username, password);

			if (response?.Token is null)
			{
				return new AuthenticationResponse() { Error = response?.Error?.Message ?? "Unexpected error!" };
			}

			return await Task.FromResult(new AuthenticationResponse() { Token = response.Token });
		}

		/// <summary>
		/// Method to soft-delete an user.
		/// </summary>
		/// <param name="username">An username of the user to be soft-delete.</param>
		/// <param name="password">The user's password.</param>
		/// <returns>An exception if there is error or true for success.</returns>
		[HttpDelete("{username}")]
		public async Task<AuthenticationResponse> SoftDeleteUser([FromQuery] string username, [FromQuery] string password)
		{
			JWTResponseOrError response = await _jwtAuthenticationsManager.AuthenticateAsync(username, password);

			if (response?.Token is null)
			{
				return new AuthenticationResponse()
				{ 
					Error = "Either the password is incorrect or the user does not exist! You need to be an authenticated and active user to delete your profile." 
				};
			}

			await _jwtAuthenticationsManager.SoftDeleteUserAsync(username);

			return new AuthenticationResponse() { Message = "Successful delete!" };
		}
	}
}
