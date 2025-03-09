using FM.Services.Interfaces;
using FM.Services.Messaging;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
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
	public class AthleteController : ControllerBase
	{
		private readonly IAthleteService _athleteService;

		public AthleteController(IAthleteService athleteService)
		{
			_athleteService = athleteService;
		}

		/// <summary>
		/// Get athlete list.
		/// </summary>
		/// <returns>Retrun list of athletes.</returns>
		[HttpGet]

		[ProducesResponseType(typeof(GetAllAthletesRequest), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetMovie()
			=> Ok(await _athleteService.GetAllAthletesAsync(new()));


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
		//=> Ok(await _athleteService.GetByNameAsync(new (name)));
		//public async Task<IActionResult> GetAthleteByName([FromRoute] string name)
		{
			var response = await _athleteService.GetByNameAsync(new GetByNameRequest(name));
			if (response.StatusCode == BusinessStatusCodeEnum.MissingObject)
			{
				return NotFound("Athlete not found.");
			}

			var okResp = Ok(response);

			return okResp;
		}


		/// <summary>
		/// Save athlete.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpPost]
		[ProducesResponseType(typeof(CreateAthleteResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> CreateMovie([FromBody] AthleteModel model)
			=> Ok(await _athleteService.SaveAsync(new(model)));

		//public async Task<IActionResult> CreateAthlete([FromBody] CreateAthleteRequest request)
		//{
		//    var response = await _athleteService.SaveAsync(request);
		//    if (response.StatusCode == BusinessStatusCodeEnum.InternalServerError)
		//    {
		//        return StatusCode(500, "Error creating athlete.");
		//    }

		//    return Ok(response);
		//}

		// TODO: Delete
	}
}
