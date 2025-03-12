using Azure.Core;
using FM.Services.Implementations;
using FM.Services.Interfaces;
using FM.Services.Messaging;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using FM.Services.Messaging.Teams.Requests;
using FM.Services.Messaging.Teams.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FM.Web.Controllers
{
	/// <summary>
	/// Teams controller.
	/// </summary>
	//[Authorize]
	[Produces("application/json")]
	[Route("api/[controller]")]
	[ApiController]
	public class TeamsController(ITeamService teamService) : ControllerBase
	{
		private readonly ITeamService _teamService = teamService;

		/// <summary>
		/// Get teams list.
		/// </summary>
		/// <returns>Retrun list of teams.</returns>
		[HttpGet]
		[ProducesResponseType(typeof(GetAllTeamsResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAllTeams()
			=> Ok(await _teamService.GetAllTeamsAsync());

		/// <summary>
		/// Get team by id.
		/// </summary>
		/// <param name="id">Team id.</param>
		/// <returns>Single team filtered by id.</returns>
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(GetTeamByIdResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> GetTeamById([FromRoute] int id)
			=> Ok(await _teamService.GetTeamByIdAsync(new GetTeamByIdRequest(id)));

		/// <summary>
		/// Save team.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpPost]
		[ProducesResponseType(typeof(CreateTeamResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateTeam([FromBody] CreateTeamModel model)
			=> Ok(await _teamService.CreateTeamAsync(new CreateTeamRequest(model)));

		/// <summary>
		/// Update a team.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpPut("{id}")]
		[ProducesResponseType(typeof(UpdateTeamResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateTeam([FromRoute] int id, [FromBody] UpdateTeamRequest request)
			=> Ok(await _teamService.UpdateTeamAsync(id, request));

		/// <summary>
		/// Soft delete a team.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpDelete("{id}")]
		[ProducesResponseType(typeof(DeleteTeamResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> SoftDeleteTeam([FromRoute] int id)
			=> Ok(await _teamService.SoftDeleteTeamAsync(new DeleteTeamRequest(id)));
	}
}
