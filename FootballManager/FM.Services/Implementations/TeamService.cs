using FM.Data.Contexts;
using FM.Data.Entities;
using FM.Services.Interfaces;
using FM.Services.Messaging;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using FM.Services.Messaging.Teams.Requests;
using FM.Services.Messaging.Teams.Responses;
using Microsoft.EntityFrameworkCore;

namespace FM.Services.Implementations
{
	/// <inheritdoc/>
	public class TeamService : ITeamService
	{
		private readonly FootballManagerDbContext _context;

		/// <summary>
		/// Initializes a new instance of the <see cref="TeamService"/> class.
		/// </summary>
		/// <param name="context">FootballManager database context.</param>
		public TeamService(FootballManagerDbContext context)
		{
			_context = context;
		}

		/// <inheritdoc/>
		public async Task<GetAllTeamsResponse> GetAllTeamsAsync()
		{
			var response = new GetAllTeamsResponse { Teams = new() };

			var teams = await _context.Teams.Where(t => t.IsActive).ToListAsync();

			if (!teams.Any())
			{
				response.Message = "No teams found.";
				response.StatusCode = BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			foreach (var team in teams)
			{
				response.Teams.Add(new()
				{
					Id = team.Id,
					Name = team.Name,
					City = team.City,
					Earnings = team.Earnings
				});
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<GetTeamByIdResponse> GetTeamByIdAsync(GetTeamByIdRequest request)
		{
			var response = new GetTeamByIdResponse();

			var team = await _context.Teams.Where(t => t.IsActive).SingleOrDefaultAsync(t => t.Id == request.Id);

			if (team == null)
			{
				response.Message = "Team not found, it could be already inactive.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			response.Team = new TeamViewModel
			{
				Id = team.Id,
				Name = team.Name,
				City = team.City,
				Earnings = team.Earnings
			};

			response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;

			return response;
		}

		/// <inheritdoc/>
		public async Task<CreateTeamResponse> CreateTeamAsync(CreateTeamRequest request)
		{
			var response = new CreateTeamResponse();

			try
			{
				var team = new Team
				{
					Name = request.Team.Name,
					City = request.Team.City,
					Earnings = request.Team.Earnings
				};

				await _context.Teams.AddAsync(team);
				await _context.SaveChangesAsync();

				response.Message = "Team successfully created.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			}
			catch
			{
				response.Message = "Internal server error has occured.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<UpdateTeamResponse> UpdateTeamAsync(int id, UpdateTeamRequest request)
		{
			var response = new UpdateTeamResponse();

			var team = await _context.Teams.SingleOrDefaultAsync(t => t.Id == id && t.IsActive);

			if (team == null)
			{
				response.Message = "Team not found, it could be already inactive.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			try
			{
				team.Name = request.Name ?? team.Name;
				team.City = request.City ?? team.City;
				team.Earnings = request.Earnings ?? team.Earnings;

				_context.Teams.Update(team);
				await _context.SaveChangesAsync();

				response.Message = "Team successfuly updated.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			}
			catch
			{
				response.Message = "Internal server error has occured.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<DeleteTeamResponse> SoftDeleteTeamAsync(DeleteTeamRequest request)
		{
			var response = new DeleteTeamResponse();

			var team = await _context.Teams.SingleOrDefaultAsync(t => t.Id == request.Id && t.IsActive);

			if (team == null)
			{
				response.Message = "Team not found or already inactive.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			try
			{
				team.IsActive = false;
				_context.Teams.Update(team);
				await _context.SaveChangesAsync();

				response.Message = "Team successfuly deleted.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			}
			catch
			{
				response.Message = "Internal server error has occured.";
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
			}

			return response;
		}
	}
}
