using FM.Services.Messaging.Teams.Requests;
using FM.Services.Messaging.Teams.Responses;

namespace FM.Services.Interfaces
{
	public interface ITeamService
	{
		Task<GetAllTeamsResponse> GetAllTeamsAsync();

		Task<GetTeamByIdResponse> GetTeamByIdAsync(GetTeamByIdRequest id);

		Task<CreateTeamResponse> CreateTeamAsync(CreateTeamRequest request);

		Task<UpdateTeamResponse> UpdateTeamAsync(int id, UpdateTeamRequest request);

		Task<DeleteTeamResponse> SoftDeleteTeamAsync(DeleteTeamRequest request);
	}
}
