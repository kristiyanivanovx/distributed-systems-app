using FM.Services.Implementations;
using FM.Services.Interfaces;
using FM.Services.Messaging;
using FM.Services.Messaging.Authentication;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FM.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransferController : ControllerBase
	{
		private ITransferService _transferService;
		public TransferController(ITransferService transferService)
		{
			_transferService = transferService;
		}

		/// <summary>
		/// Get transfer list.
		/// </summary>
		/// <returns>Retrun list of transfers.</returns>
		[HttpGet]
		[ProducesResponseType(typeof(GetAllAthletesRequest), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAllTransfers()
			=> Ok(await _transferService.GetAllTransfersAsync(new()));

		/// <summary>
		/// Get transfer by id.
		/// </summary>
		/// <param name="id">Transfer id.</param>
		/// <returns>Single id filtered by id.</returns>
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(GetByNameResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetTransferById([FromRoute] int id)
			=> Ok(await _transferService.GetByIdAsync(new GetByIdRequest(id) { Id = id }));

		/// <summary>
		/// Save transfer.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpPost]
		[ProducesResponseType(typeof(CreateAthleteResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> CreateTransfer([FromBody] TransferCreateModel model)
			=> Ok(await _transferService.SaveAsync(new(model)));

		/// <summary>
		/// Soft delete an transfer.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpDelete("{id}")]
		[ProducesResponseType(typeof(DeleteTransferResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(typeof(ServiceResponseError), StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> DeleteTransfer([FromRoute] int id)
			=> Ok(await _transferService.SoftDeleteTransferAsync(new DeleteTransferRequest { Id = id }));
	}
}
