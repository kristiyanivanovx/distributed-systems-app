using FM.Services.Interfaces;
using FM.Services.Messaging;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FM.Web.Controllers
{
    /// <summary>
    /// Athletes controller.
    /// </summary>
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AthletesController(IAthleteService athleteService) : ControllerBase
    {
        private readonly IAthleteService _athleteService = athleteService;

		/// <summary>
		/// Get athlete list.
		/// </summary>
		/// <returns>Retrun list of athletes.</returns>
		[HttpGet]
        [ProducesResponseType(typeof(GetAllAthletesRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAthletes() 
            => Ok(await _athleteService.GetAllAthletesAsync(new ()));

        /// <summary>
        /// Get athlete by name.
        /// </summary>
        /// <param name="name">Athlete name.</param>
        /// <returns>Single athlete filtered by name.</returns>
        [HttpGet("{name}")]
        [ProducesResponseType(typeof(GetByNameResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAthleteByName([FromRoute] string name)
            => Ok(await _athleteService.GetByNameAsync(new GetByNameRequest(name) { Name = name }));

        /// <summary>
        /// Save athlete.
        /// </summary>
        /// <returns>Return null if not successful.</returns>
        [HttpPost]
		[Authorize]
		[ProducesResponseType(typeof(CreateAthleteResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAthlete([FromBody] AthleteCreateModel model) 
            => Ok(await _athleteService.CreateAthleteAsync(new (model)));

        /// <summary>
        /// Update an athlete.
        /// </summary>
        /// <returns>Return null if not successful.</returns>
        [HttpPut("{id}")]
		[Authorize]
		[ProducesResponseType(typeof(UpdateAthleteResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAthlete([FromRoute] int id, [FromBody] UpdateAthleteRequest request)
            => Ok(await _athleteService.UpdateAthleteAsync(id, request));

		/// <summary>
		/// Soft delete an athlete.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpDelete("{id}")]
		[Authorize]
		[ProducesResponseType(typeof(DeleteAthleteResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> DeleteAthlete([FromRoute] int id)
			=> Ok(await _athleteService.SoftDeleteAthleteAsync(new DeleteAthleteRequest { Id = id }));
	}
}
