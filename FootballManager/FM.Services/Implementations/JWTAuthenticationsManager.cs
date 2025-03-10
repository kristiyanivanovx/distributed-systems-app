using FM.Data.Contexts;
using FM.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using FM.Data.Entities;
using FM.Services.Messaging;
using FM.Services.Messaging.Authentication;

namespace FM.Services.Implementations
{
	public class JWTAuthenticationsManager : IJWTAuthenticationsManager
	{
		private readonly FootballManagerDbContext _context;
		private readonly string tokenKey;

		public JWTAuthenticationsManager(FootballManagerDbContext context, string tokenKey)
		{
			this._context = context;
			this.tokenKey = tokenKey;
		}

		private string CreateToken(string username)
		{
			JwtSecurityTokenHandler handler = new();
			var key = Encoding.ASCII.GetBytes(tokenKey);
			SecurityTokenDescriptor tokenDescriptor = new()
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new Claim(ClaimTypes.Name, username),
				}),
				Expires = DateTime.UtcNow.AddMinutes(30),
				SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
			};

			var token = handler.CreateToken(tokenDescriptor);
			return handler.WriteToken(token);
		}

		public async Task<JWTResponseOrError> AuthenticateAsync(string username, string password)
		{
			var user = await _context.User.SingleOrDefaultAsync(x => x.Username == username && x.IsActive);

			if (user == null || !PasswordHelper.VerifyPassword(password, user.Password))
			{
				// User not found or password incorrect
				return new JWTResponseOrError(BusinessStatusCodeEnum.MissingObject, "User not found or password incorrect.");
			}

			return new JWTResponseOrError { Token = CreateToken(username) };
		}

		public async Task<JWTResponseOrError> RegisterUserAsync(string username, string password)
		{
			if (await _context.User.AnyAsync(u => u.Username == username))
			{
				return new JWTResponseOrError(BusinessStatusCodeEnum.ObjectAlreadyExists, "User already exists.");
			}

			string hashedPassword = PasswordHelper.HashPassword(password);
			var newUser = new User { Username = username, Password = hashedPassword };

			_context.User.Add(newUser);
			await _context.SaveChangesAsync();

			return new JWTResponseOrError { Token = CreateToken(username) };
		}

		public async Task<JWTResponseOrError> SoftDeleteUserAsync(string username)
		{
			var user = await _context.User.SingleOrDefaultAsync(u => u.Username == username);
			if (user == null || !user.IsActive)
			{
				return new JWTResponseOrError(BusinessStatusCodeEnum.MissingObject, "User not found or already inactive.");

			}

			user.IsActive = false;
			_context.User.Update(user);
			await _context.SaveChangesAsync();

			return new JWTResponseOrError(BusinessStatusCodeEnum.Success);
		}
	}
}

