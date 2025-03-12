using FM.Data.Contexts;
using FM.Data.Entities;
using FM.Services.Interfaces;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using Microsoft.EntityFrameworkCore;

namespace FM.Services.Implementations
{
	/// <inheritdoc/>
	public class AthleteService : IAthleteService
	{
		private readonly FootballManagerDbContext _context;

		/// <summary>
		/// Initializes a new instance of the <see cref="AthleteService"/> class.
		/// </summary>
		/// <param name="context">FootballManager database context.</param>
		public AthleteService(FootballManagerDbContext context)
		{
			_context = context;
		}

		/// <inheritdoc/>
		public async Task<GetAllAthletesResponse> GetAllAthletesAsync(GetAllAthletesRequest request)
		{
			GetAllAthletesResponse response = new() { Athletes = new() };

			var athletes = await _context.Athletes
				.Where(x => x.IsActive)
				.Include(a => a.Team)
				.ToListAsync();

			if (athletes is null || !athletes.Any())
			{
				return response;
			}

			foreach (var athlete in athletes)
			{
				response.Athletes.Add(new()
				{
					Id = athlete.Id,
					FirstName = athlete.FirstName,
					LastName = athlete.LastName,
					Nationality = athlete.Nationality,
					MarketValue = athlete.MarketValue,
					TeamName = athlete.Team?.Name ?? "No team",
					TeamId = athlete.TeamId,
					Position = athlete.Position.ToString(),
				});
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<GetByNameResponse> GetByNameAsync(GetByNameRequest request)
		{
			GetByNameResponse response = new();

			var athlete = await _context.Athletes
				.Where(x => x.IsActive)
				.Include(a => a.Team)
				.SingleOrDefaultAsync(x => x.FirstName == request.Name || x.LastName == request.Name);

			if (athlete is null)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			response.Athlete = new()
			{
				Id = athlete.Id,
				FirstName = athlete.FirstName,
				LastName = athlete.LastName,
				Nationality = athlete.Nationality,
				MarketValue = athlete.MarketValue,
				TeamName = athlete.Team?.Name ?? "No team",
				TeamId = athlete.TeamId,
				Position = athlete.Position.ToString(),
			};

			response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			return response;
		}

		/// <inheritdoc/>
		public async Task<CreateAthleteResponse> CreateAthleteAsync(CreateAthleteRequest request)
		{
			CreateAthleteResponse response = new();

			try
			{
				var athlete = new Athlete()
				{
					FirstName = request.Athlete.FirstName,
					LastName = request.Athlete.LastName,
					Nationality = request.Athlete.Nationality,
					MarketValue = request.Athlete.MarketValue,
					TeamId = request.Athlete.TeamId,
					Position = request.Athlete.Position
				};

				await _context.Athletes.AddAsync(athlete);
				await _context.SaveChangesAsync();

				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;

			}
			catch (Exception ex)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
				return response;
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<UpdateAthleteResponse> UpdateAthleteAsync(int id, UpdateAthleteRequest request)
		{
			UpdateAthleteResponse response = new();

			var athlete = await _context.Athletes
				.Include(a => a.Team)
				.SingleOrDefaultAsync(x => x.Id == id);

			if (athlete is null)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			try
			{
				athlete.FirstName = request.Athlete?.FirstName ?? athlete.FirstName;
				athlete.LastName = request.Athlete?.LastName ?? athlete.LastName;
				athlete.Nationality = request.Athlete?.Nationality ?? athlete.Nationality;
				athlete.MarketValue = request.Athlete?.MarketValue ?? athlete.MarketValue;
				athlete.Position = request.Athlete?.Position ?? athlete.Position;

				if (request.Athlete?.TeamId.HasValue == true)
				{
					athlete.TeamId = request.Athlete.TeamId.Value;
				}

				_context.Athletes.Update(athlete);
				await _context.SaveChangesAsync();

				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			}
			catch (Exception ex)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<DeleteAthleteResponse> SoftDeleteAthleteAsync(DeleteAthleteRequest request)
		{
			DeleteAthleteResponse response = new();

			var athlete = await _context.Athletes.SingleOrDefaultAsync(x => x.Id == request.Id && x.IsActive);

			if (athlete is null)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			try
			{
				athlete.IsActive = false;

				_context.Athletes.Update(athlete);

				await _context.SaveChangesAsync();

				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			}
			catch (Exception)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
			}

			return response;
		}
	}
}
